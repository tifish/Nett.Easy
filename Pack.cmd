@echo off
setlocal enabledelayedexpansion
cd /d "%~dp0"

rd /s /q "Nett.Easy\bin\Release"

dotnet pack Nett.Easy -c Release || pause

set localNugetPath=%USERPROFILE%\LocalNuget
mkdir "%localNugetPath%"
dotnet nuget add source "%localNugetPath%" -n LocalTest
copy /y "Nett.Easy\bin\Release\*.nupkg" "%localNugetPath%" || pause

endlocal
