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
@xcopy /y ..\PJSip.Interop\bin\Release\PJSip.Interop.dll bin\lib\
@xcopy /y ..\PJSip.Interop\bin\Release\PJSip.Interop.pdb bin\lib\

@echo Copy native dll pjsua2
@copy /y ..\pjsip-apps\lib\pjsua2_net_native-x86_64-x64-vc12-Release-Static.dll bin\build\x64\pjsua2.dll
@copy /y ..\pjsip-apps\lib\pjsua2_net_native-i386-Win32-vc12-Release-Static.dll bin\build\x86\pjsua2.dll
@copy /y PJSip.Interop.targets bin\build

@echo Build package
@cd bin
@nuget.exe pack PJSip.Interop.nuspec