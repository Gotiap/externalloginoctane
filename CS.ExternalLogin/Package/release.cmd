"..\..\oqtane.framework\oqtane.package\nuget.exe" pack CS.ExternalLogin.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\wwwroot\Modules\" /Y
