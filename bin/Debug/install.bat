cd %~dp0
%~d0
taskkill /im %1.exe /f
7z.exe e   %2 -aoa
start %1.exe
del /f %2
%3
