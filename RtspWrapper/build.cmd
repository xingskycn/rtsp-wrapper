@echo off

SET GCCXML=%ProgramFiles%\gccxml 0.9\bin\gccxml.exe
IF NOT EXIST "%GCCXML%" SET GCCXML=%ProgramFiles(x86)%\gccxml 0.9\bin\gccxml.exe
IF NOT EXIST "%GCCXML%" SET GCCXML=gccxml.exe

IF "%VCINSTALLDIR%" == "" (
	IF "%VS100COMNTOOLS%" == "" (
		echo "Visual Studio not detected. Please run vcvarsall.bat manually"
		goto :eof
	) ELSE (
		call "%VS100COMNTOOLS%..\..\VC\vcvarsall.bat"
	)	
)

SET LIVE_ROOT=..\live


del /s/q/f Generated > NUL 2>&1

"%GCCXML%" -fxml=RTSPClient.xml -I%LIVE_ROOT%\UsageEnvironment\include -I%LIVE_ROOT%\liveMedia\include -I%LIVE_ROOT%\groupsock\include -I%LIVE_ROOT%\BasicUsageEnvironment\include includes.h

..\..\cxxi\bin\Debug\generator.exe --filters=filters.xml -o=Generated -ns=Live555Rtsp -lib=live555 -inline=present -abi=msvc RTSPClient.xml

::del /s/q RTSPClient.xml