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

public class OnCallReplaceRequestParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnCallReplaceRequestParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnCallReplaceRequestParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OnCallReplaceRequestParam() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_OnCallReplaceRequestParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SipRxData rdata {
    set {
      pjsua2PINVOKE.OnCallReplaceRequestParam_rdata_set(swigCPtr, SipRxData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCallReplaceRequestParam_rdata_get(swigCPtr);
      SipRxData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipRxData(cPtr, false);
      return ret;
    } 
  }

  public pjsip_status_code statusCode {
    set {
      pjsua2PINVOKE.OnCallReplaceRequestParam_statusCode_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_status_code ret = (pjsip_status_code)pjsua2PINVOKE.OnCallReplaceRequestParam_statusCode_get(swigCPtr);
      return ret;
    } 
  }

  public string reason {
    set {
      pjsua2PINVOKE.OnCallReplaceRequestParam_reason_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.OnCallReplaceRequestParam_reason_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public CallSetting opt {
    set {
      pjsua2PINVOKE.OnCallReplaceRequestParam_opt_set(swigCPtr, CallSetting.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnCallReplaceRequestParam_opt_get(swigCPtr);
      CallSetting ret = (cPtr == global::System.IntPtr.Zero) ? null : new CallSetting(cPtr, false);
      return ret;
    } 
  }

  public OnCallReplaceRequestParam() : this(pjsua2PINVOKE.new_OnCallReplaceRequestParam(), true) {
  }

}

}
