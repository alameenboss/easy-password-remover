@ECHO off
cls

@ECHO on
@ECHO.Building solution...
@dotnet publish -c Release -o bin/publish
@ECHO.Deleting *.pdb files...
@cd bin/publish
@del *.pdb
@ECHO.Build successful. Press any key to exit.
pause