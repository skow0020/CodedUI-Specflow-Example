@echo off
REM Usage: Run.bat <OPTIONAL_SCENARIO_CATEGORY>

SET category=/category:%1

For /f "tokens=2-4 delims=/ " %%a in ('date /t') do (set mydate=%%a%%b)
For /f "tokens=1-2 delims=/:,/ " %%a in ('time /t') do (set mytime=%%a%%b)

SET resultsFile=TestResults_%mydate%_%mytime%.trx

REM Clean and Build the testing solution
"D:/Program Files (x86)/Microsoft Visual Studio 14.0/Common7/IDE/devenv" CodedUIExample.sln /Clean
"D:/Program Files (x86)/Microsoft Visual Studio 14.0/Common7/IDE/devenv" CodedUIExample.sln /Build "Debug|AnyCPU"

REM Kick off tests
"D:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\MSTest.exe" /testcontainer:CodedUIExample\bin\Debug\CodedUIExample.dll %category% /resultsfile:%resultsFile%

REM Create test report file from trxer
REM TrxerConsole.exe %resultsFile%