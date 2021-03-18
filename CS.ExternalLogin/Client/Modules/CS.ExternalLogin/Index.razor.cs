using CS.ExternalLogin.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Oqtane.Models;
using Oqtane.Modules;
using Oqtane.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CS.ExternalLogin
{
    public class IndexModel : ModuleBase
    {
        protected string _returnUrl = string.Empty;
        protected string _message = string.Empty;
        protected MessageType _type = MessageType.Info;
        protected string _username = string.Empty;
        protected string _password = string.Empty;
        protected bool _remember = false;


        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected IExternalLoginService ExternalLoginService { get; set; }

        [Inject]
        protected IServiceProvider ServiceProvider { get; set; }

        [Inject]
        protected IStringLocalizer<IndexModel> Localizer { get; set; }

        public override SecurityAccessLevel SecurityAccessLevel => SecurityAccessLevel.Anonymous;

        public override List<Resource> Resources => new List<Resource>() { new Resource { ResourceType = ResourceType.Stylesheet, Url = ModulePath() + "Module.css" } };

        protected override async Task OnInitializedAsync()
        {
            if (PageState.QueryString.ContainsKey("returnurl"))
            {
                _returnUrl = PageState.QueryString["returnurl"];
            }

            if (PageState.QueryString.ContainsKey("name"))
            {
                _username = PageState.QueryString["name"];
            }

            if (PageState.QueryString.ContainsKey("token"))
            {
                var user = new User();
                user.SiteId = PageState.Site.SiteId;
                user.Username = _username;
                user = await ExternalLoginService.VerifyEmailAsync(user, PageState.QueryString["token"]);

                if (user != null)
                {
                    _message = Localizer["User Account Verified Successfully. You Can Now Login With Your Username And Password Below."];
                }
                else
                {
                    _message = Localizer["User Account Could Not Be Verified. Please Contact Your Administrator For Further Instructions."];
                    _type = MessageType.Warning;
                }
            }
        }

        protected async Task Login()
        {
            //if (PageState.Runtime == Oqtane.Shared.Runtime.Server)
            //{
            //    // server-side Blazor
            //    var user = new User();
            //    user.SiteId = PageState.Site.SiteId;
            //    user.Username = _username;
            //    user.Password = _password;
            //    user = await UserService.LoginUserAsync(user, false, false);

            //    if (user.IsAuthenticated)
            //    {
            //        await logger.LogInformation("Login Successful For Username {Username}", _username);
            //        // complete the login on the server so that the cookies are set correctly on SignalR
            //        var interop = new Interop(JSRuntime);
            //        string antiforgerytoken = await interop.GetElementByName("__RequestVerificationToken");
            //        var fields = new { __RequestVerificationToken = antiforgerytoken, username = _username, password = _password, remember = _remember, returnurl = _returnUrl };
            //        await interop.SubmitForm($"/{PageState.Alias.AliasId}/pages/login/", fields);
            //    }
            //    else
            //    {
            //        await logger.LogInformation("Login Failed For Username {Username}", _username);
            //        AddModuleMessage(Localizer["Login Failed. Please Remember That Passwords Are Case Sensitive And User Accounts Require Email Verification When They Initially Created."], MessageType.Error);
            //    }
            //}
            //else
            //{
            // client-side Blazor
            var user = new User();
            user.SiteId = PageState.Site.SiteId;
            user.Username = _username;
            user.Password = _password;
            user = await ExternalLoginService.LoginUserAsync(user, true, _remember);
            if (user.IsAuthenticated)
            {
                await logger.LogInformation("Login Successful For Username {Username}", _username);
                //var authstateprovider = (IdentityAuthenticationStateProvider)ServiceProvider.GetService(typeof(IdentityAuthenticationStateProvider));
                //authstateprovider.NotifyAuthenticationChanged();
                NavigationManager.NavigateTo(NavigateUrl(_returnUrl, "reload"));
            }
            else
            {
                await logger.LogInformation("Login Failed For Username {Username}", _username);
                AddModuleMessage(Localizer["Login Failed. Please Remember That Passwords Are Case Sensitive And User Accounts Require Verification When They Are Initially Created So You May Wish To Check Your Email."], MessageType.Error);
            }
            //}
        }

        protected void Cancel()
        {
            NavigationManager.NavigateTo(_returnUrl);
        }

        protected async Task Forgot()
        {
            if (_username != string.Empty)
            {
                var user = await ExternalLoginService.GetUserAsync(_username, PageState.Site.SiteId);
                if (user != null)
                {
                    await ExternalLoginService.ForgotPasswordAsync(user);
                    _message = "Please Check The Email Address Associated To Your User Account For A Password Reset Notification";
                }
                else
                {
                    _message = "User Does Not Exist";
                    _type = MessageType.Warning;
                }
            }
            else
            {
                _message = "Please Enter The Username Related To Your Account And Then Select The Forgot Password Option Again";
            }

            StateHasChanged();
        }
    }
}
