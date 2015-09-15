//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace PJSip.Interop {

public class CallSetting : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CallSetting(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CallSetting obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CallSetting() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_CallSetting(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint flag {
    set {
      pjsua2PINVOKE.CallSetting_flag_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CallSetting_flag_get(swigCPtr);
      return ret;
    } 
  }

  public uint reqKeyframeMethod {
    set {
      pjsua2PINVOKE.CallSetting_reqKeyframeMethod_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CallSetting_reqKeyframeMethod_get(swigCPtr);
      return ret;
    } 
  }

  public uint audioCount {
    set {
      pjsua2PINVOKE.CallSetting_audioCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CallSetting_audioCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint videoCount {
    set {
      pjsua2PINVOKE.CallSetting_videoCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.CallSetting_videoCount_get(swigCPtr);
      return ret;
    } 
  }

  public CallSetting(SWIGTYPE_p_pj_bool_t useDefaultValues) : this(pjsua2PINVOKE.new_CallSetting__SWIG_0(SWIGTYPE_p_pj_bool_t.getCPtr(useDefaultValues)), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public CallSetting() : this(pjsua2PINVOKE.new_CallSetting__SWIG_1(), true) {
  }

  public bool isEmpty() {
    bool ret = pjsua2PINVOKE.CallSetting_isEmpty(swigCPtr);
    return ret;
  }

}

}
