#pragma checksum "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\Modules\CS.ExternalLogin\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3f5143d3557955e00f4ce90c4922464a97a74ed"
// <auto-generated/>
#pragma warning disable 1591
namespace CS.ExternalLogin
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Modules;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Modules.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Providers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Themes.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\_Imports.razor"
using Oqtane.Enums;

#line default
#line hidden
#nullable disable
    public partial class Settings : ModuleBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-borderless");
            __builder.OpenElement(2, "tr");
            __builder.OpenElement(3, "td");
            __builder.OpenComponent<Oqtane.Modules.Controls.Label>(4);
            __builder.AddAttribute(5, "For", "value");
            __builder.AddAttribute(6, "HelpText", "Add API Url");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, "Add API Url: ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "id", "value");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\Modules\CS.ExternalLogin\Settings.razor"
                                                                       _value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _value = __value, _value));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "D:\Goti\CreativeSims\Demo\Oqtane\ExModule\CS.ExternalLogin\Client\Modules\CS.ExternalLogin\Settings.razor"
       
    public override string Title => "ExternalLogin Settings";

    string _value;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Dictionary<string, string> settings = await SettingService.GetModuleSettingsAsync(ModuleState.ModuleId);
            _value = SettingService.GetSetting(settings, "APIURL", "");
        }
        catch (Exception ex)
        {
            ModuleInstance.AddModuleMessage(ex.Message, MessageType.Error);
        }
    }

    public async Task UpdateSettings()
    {
        try
        {
            Dictionary<string, string> settings = await SettingService.GetModuleSettingsAsync(ModuleState.ModuleId);
            SettingService.SetSetting(settings, "APIURL", _value);
            await SettingService.UpdateModuleSettingsAsync(settings, ModuleState.ModuleId);
        }
        catch (Exception ex)
        {
            ModuleInstance.AddModuleMessage(ex.Message, MessageType.Error);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISettingService SettingService { get; set; }
    }
}
#pragma warning restore 1591