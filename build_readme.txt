https://trac.pjsip.org/repos/wiki/Getting-Started/Android

1. export ANDROID_NDK_ROOT=/path_to_android_ndk_dir

2. export TARGET_ABI=armeabi|armeabi-v7a|x86

3. export APP_PLATFORM=android-15

4. ./configure-android --use-ndk-cflags --with-ssl=[your_openssl_path]/openssl-1.0.2a

5. make clean && make dep && make

6. cd pjsip-apps/src/swig
   make clean && make