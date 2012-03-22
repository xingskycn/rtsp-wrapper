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



"%GCCXML%" -fxml=RTSPClient.xml -Ilive\UsageEnvironment\include -Ilive\groupsock\include live\liveMedia\include\RTSPClient.hh

..\cxxi\bin\Debug\generator.exe -o=generated -ns=Tests -lib=libtest -inline=present -abi=msvc RTSPClient.xml