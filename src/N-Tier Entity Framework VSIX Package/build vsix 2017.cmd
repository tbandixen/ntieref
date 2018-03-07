@ECHO OFF
ECHO.
ECHO RESTORE NUGET PACKAGES
"%~dp0..\..\tools\NuGet\NuGet.exe" restore "%~dp0..\N-Tier Entity Framework\N-Tier Entity Framework.sln"
ECHO.
ECHO BUILD AND PACKAGE
SETLOCAL
PATH=%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Professional\MSBuild\15.0\Bin;%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\MSBuild\15.0\Bin;%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Community\MSBuild\15.0\Bin;%ProgramFiles(x86)%\MSBuild\14.0\Bin;%SystemRoot%\Microsoft.NET\Framework\v4.0.30319;%PATH%
MSBuild.exe "%~dp0\N-Tier Entity Framework VSIX Package.v15.sln" /target:Rebuild /verbosity:minimal /maxcpucount /nodeReuse:false /property:Configuration=Release;VsixVersion=1.9;NugetPackageVersion=1.9.0;VisualStudioVersion=15.0 %*
ENDLOCAL
ECHO.
PAUSE