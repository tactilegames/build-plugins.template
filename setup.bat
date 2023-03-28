@echo off

set SCRIPT_DIR=%~dp0
cd /D %SCRIPT_DIR%

echo %SCRIPT_DIR%

set "verbose=0"
if "%1" == "--verbose" (
  set "verbose=1"
)

echo.
echo.
echo ---------------------
echo Name your new plugin
echo ---------------------

echo - Enter the new Build Plugin name:
echo (Note: Use PascalCase and avoid using any suffix, the tool will take care of that.)
set /p plugin_name=

for /f "tokens=* delims= " %%a in ("%plugin_name%") do (
  set "plugin_name=%%~a"
)

call :toPascalCase "%plugin_name%"
set "plugin_name=%RESULT%"

if %verbose% equ 1 (
  echo ---------------------
  echo Renaming Directories
  echo ---------------------
)

for /f "delims=" %%d in ('dir /b /s /ad *PLUGIN_NAME* ^| findstr /v /i "/.git/"') do (
  call :renameAndMove "%%d"
)

if %verbose% equ 1 (
  echo ------------------------
  echo Replacing files content
  echo ------------------------
)

for /f "delims=" %%f in ('dir /b /s /a-d *PLUGIN_NAME* ^| findstr /v /i "/.git/"') do (
  call :replaceInFile "%%f"
)

if %verbose% equ 1 (
  echo ------------------------
  echo Renaming files name
  echo ------------------------
)

for /f "delims=" %%f in ('dir /b /s /a-d *PLUGIN_NAME* ^| findstr /v /i "/.git/"') do (
  call :renameAndMove "%%f"
)

if %verbose% equ 1 (
  echo ------------------------
  echo Renaming root folder
  echo ------------------------
)

for %%I in (.) do set "parent_folder_name=%%~nxI"
cd ..
call :renameAndMove "%parent_folder_name%"

if %verbose% equ 1 (
  echo Renamed parent folder %parent_folder_name% to %new_name%
)

del "%new_name%/setup.bat"

echo ------------------------
echo Enjoy coding!
echo ------------------------

goto :eof

:toPascalCase
for /f "tokens=* delims= " %%a in ("%~1") do (
  set "RESULT=%%~a"
)
set "RESULT=%RESULT: =%"
goto :eof

:renameAndMove
set "old_name=%~1"
set "new_name=%old_name:PLUGIN_NAME=%plugin_name%%"
move "%old_name%" "%new_name%"
goto :eof

:replaceInFile
set "file=%~1"
powershell -Command "(gc '%file%') -replace 'PLUGIN_NAME', '%plugin_name%' | Set-Content '%file%'"
goto :eof
