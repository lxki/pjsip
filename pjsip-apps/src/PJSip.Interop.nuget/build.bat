@echo off

@cd %~dp0

@echo Clean Output dir
@if exist bin rmdir /S /Q bin

@echo Create Output dir

@mkdir bin\lib 
@mkdir bin\build\x86 
@mkdir bin\build\x64 

@echo Copy NuGet spec
@xcopy /y PJSip.Interop.nuspec bin\

@echo Copy PJSip lib
@xcopy /y ..\..\bin\Release\PJSip.Interop.dll bin\lib\
@xcopy /y ..\..\bin\Release\PJSip.Interop.pdb bin\lib\

@echo Copy native dll pjsua2
@copy /y ..\..\bin\release\x86\pjsua2.dll bin\build\x86\
@copy /y ..\..\bin\release\x86\libeay32.dll bin\build\x86\
@copy /y ..\..\bin\release\x86\ssleay32.dll bin\build\x86\

@copy /y ..\..\bin\release\x64\pjsua2.dll bin\build\x64\
@copy /y ..\..\bin\release\x64\libeay32.dll bin\build\x64\
@copy /y ..\..\bin\release\x64\ssleay32.dll bin\build\x64\

@copy /y PJSip.Interop.targets bin\build

@echo Build package
@cd bin
@nuget.exe pack PJSip.Interop.nuspec