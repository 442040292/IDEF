@echo off

title Build Project
echo 1. Rebuild Release Project, Please Wait...
rem 2.rebuild Releaserem 务必根据本地电脑上的 vs 选择对应的 devenv.exe
start  /high   "compile project" /WAIT "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.exe"  "C:\mypo\StudioDemo\StudioDemo.sln" /rebuild Release /project "C:\mypo\StudioDemo\StudioDemo\StudioDemo.csproj" /projectconfig Release
if %errorlevel% == 1 (
    echo.
    echo ERROR: Compile ERROR!
    pause 
    exit
)

echo 2. Open Release Project, Please Wait...
start "" "C:\mypo\StudioDemo\StudioDemo\bin\Release\StudioDemo.exe"
exit