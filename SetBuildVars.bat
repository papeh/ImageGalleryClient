@echo off

REM Fraser Bennett 04-Jan-2021: Hasso says only the first and last lines are really important
REM The installer for the WiX toolset sets WIX=<the WiX install dir>, but doesn't add it to the path
REM REVIEW (Hasso) 2018.01: is this really this script's responsibility, or somebody else's?
set PATH=%PATH%;%WIX%\bin
REM 
REM REM the following lines query the registry for the VisualStudio 2015 install directory and run its vcvarsall.bat
REM 
REM Set RegQry=HKLM\Hardware\Description\System\CentralProcessor\0
REM 
REM REG.exe Query %RegQry% > checkOS.txt
REM 
Find /i "x86" < CheckOS.txt > StringCheck.txt
REM 
REM If %ERRORLEVEL% == 0 (
REM 	set KEY_NAME=HKLM\SOFTWARE\Microsoft\VisualStudio\14.0
REM ) ELSE (
REM 	set KEY_NAME=HKLM\SOFTWARE\Wow6432Node\Microsoft\VisualStudio\14.0
REM )
REM set KEY_NAME=%KEY_NAME%\Setup\VS
REM 
REM del CheckOS.txt
REM del StringCheck.txt
REM 
REM set VALUE_NAME=ProductDir
REM 
REM REM Check for presence of key first.
REM reg query %KEY_NAME% /v %VALUE_NAME% 2>nul || (echo Build requires VisualStudio 2015! & exit /b 1)
REM 
REM REM query the value. pipe it through findstr in order to find the matching line that has the value. only grab token 3 and the remainder of the line. %%b is what we are interested in here.
REM set INSTALL_DIR=
REM for /f "tokens=2,*" %%a in ('reg query %KEY_NAME% /v %VALUE_NAME% ^| findstr %VALUE_NAME%') do (
REM 	set PRODUCT_DIR=%%b
REM )
if "%arch%" == "" set arch=x86
REM REM original line below, but we'll call the file directly instead
REM call "%PRODUCT_DIR%\VC\vcvarsall.bat" %arch% 8.1
call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Auxiliary\Build\vcvarsall.bat" %arch% 10.0.18362.0
