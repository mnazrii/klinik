@echo off

FOR /F "skip=1 tokens=1-6" %%A IN ('WMIC Path Win32_LocalTime Get Day^,Hour^,Minute^,Month^,Second^,Year /Format:table') DO (
  SET /A MONTH=%%D>nul
  SET /A YEAR=%%F>nul
  SET /A DAy=%%A>nul
)
cls

echo %day%%month%%year%.db.bak


cd C:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\Binn


sqlcmd -U klinikuser -P password -S "KAUNTER\SQLEXPRESS" -d database_klinik  -i "%~dp0scripttable.sql" 
