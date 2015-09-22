 -- Building on Windows -- 

1. Copy & rename configuration header

  copy pjlib\include\pj\config_site_win.h pjlib\include\pj\config_site.h

2. Install SWIG (tested on swigwin-3.0.7)
  http://www.swig.org/download.html

3 Download and Install OpenSSL x86 & x64 versions 
  https://slproweb.com/products/Win32OpenSSL.html

  You need 'Win32 OpenSSL v1.0.2d' and 'Win64 OpenSSL v1.0.2d'

4. Open visual studio solution 'pjproject-vs12.sln'

5. Set up configuration properties

 - Open Property Manager ( View - Property Manager)
 - Select project libbaseclasses 

5.1 Set up OpenSSL for Win32
 - Open file 'Debug | Win32' > 'Microsoft.Cpp.Win32.user'
 - Select 'Common Properties' > 'User Macros'
 - Add macro 'OpenSSL' and specify path to OpenSSL for Win32 (e.g. 'C:\devel\Libs\OpenSSL-Win32')

5.2 Set up OpenSSL for Win64
 - Open file 'Debug | x64' > 'Microsoft.Cpp.x64.user'
 - Select 'Common Properties' > 'User Macros'
 - Add macro 'OpenSSL' and specify path to OpenSSL for Win64 (e.g. 'C:\devel\Libs\OpenSSL-Win64	')

6. Build project
 - Select configuration 'Release'

 - Select platform 'Win32' and Build solution
 - Select platform 'x64'and Build solution

7. Building nuget package (optional)

  cd pjsip-apps\src\PJSip.Interop.nuget
  build.bat

Publishing nuget package optional
  nuget push PJSip.Interop.0.7.1.nupkg 


