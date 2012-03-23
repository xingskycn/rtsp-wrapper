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


del /s/q/f generated > NUL 2>&1

"%GCCXML%" -fxml=RTSPClient.xml -Ilive\UsageEnvironment\include -Ilive\groupsock\include live\liveMedia\include\RTSPClient.hh

..\cxxi\bin\Debug\generator.exe --filters=filters.xml -o=generated -ns=Tests -lib=libtest -inline=present -abi=msvc RTSPClient.xml