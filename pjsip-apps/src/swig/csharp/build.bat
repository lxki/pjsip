@C:\Progs\swigwin-3.0.7\swig.exe ^
  -I../../../../pjlib/include^
  -I../../../../pjlib-util/include ^
  -I../../../../pjmedia/include ^
  -I../../../../pjsip/include ^
  -I../../../../pjnath/include ^
  -w312 -c++ -csharp ^
  -outdir managed ^
  -namespace PJSip.Interop ^
  -o native/pjsua2_wrap.cpp ^
  ../pjsua2.i
