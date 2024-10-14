@ECHO off

DEL /q build
dotnet clean source -c Release

dotnet test source -c Release

IF %ERRORLEVEL% GTR 0 GOTO :end

dotnet pack source -c Release -o build /p:Version=0-local%Date:~6,4%%Date:~3,2%%Date:~0,2%%Time:~0,2%%Time:~3,2%%Time:~6,2% /p:SignAssembly=true

:end