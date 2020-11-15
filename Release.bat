@ECHO off

DEL /q package
dotnet clean source\DefaultUnDo\DefaultUnDo.csproj -c Release
dotnet clean source\DefaultUnDo.Test\DefaultUnDo.Test.csproj -c Release

dotnet test source\DefaultUnDo.Test\DefaultUnDo.Test.csproj -c Release -r package -l trx

IF %ERRORLEVEL% GTR 0 GOTO :end

dotnet pack source\DefaultUnDo\DefaultUnDo.csproj -c Release -o package /p:LOCAL_VERSION=true

:end