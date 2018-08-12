::@echo off

FOR /F "skip=1 tokens=1-6" %%A IN ('WMIC Path Win32_LocalTime Get Day^,Hour^,Minute^,Month^,Second^,Year /Format:table') DO (
  SET /A MONTH=%%D>nul
  SET /A YEAR=%%F>nul
  SET /A DAy=%%A>nul
)
cls

echo %day%%month%%year%.db.bak


cd C:\Program Files\Microsoft SQL Server\110\Tools\Binn


sqlcmd -S"(LocalDB)\MSSQLLocalDB" -d C:\db\klinikdb.mdf  -i "%~dp0scripttable.sql" 
pause
