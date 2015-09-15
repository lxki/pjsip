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

public class RtcpStat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RtcpStat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RtcpStat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RtcpStat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_RtcpStat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TimeVal start {
    set {
      pjsua2PINVOKE.RtcpStat_start_set(swigCPtr, TimeVal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.RtcpStat_start_get(swigCPtr);
      TimeVal ret = (cPtr == global::System.IntPtr.Zero) ? null : new TimeVal(cPtr, false);
      return ret;
    } 
  }

  public RtcpStreamStat txStat {
    set {
      pjsua2PINVOKE.RtcpStat_txStat_set(swigCPtr, RtcpStreamStat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.RtcpStat_txStat_get(swigCPtr);
      RtcpStreamStat ret = (cPtr == global::System.IntPtr.Zero) ? null : new RtcpStreamStat(cPtr, false);
      return ret;
    } 
  }

  public RtcpStreamStat rxStat {
    set {
      pjsua2PINVOKE.RtcpStat_rxStat_set(swigCPtr, RtcpStreamStat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.RtcpStat_rxStat_get(swigCPtr);
      RtcpStreamStat ret = (cPtr == global::System.IntPtr.Zero) ? null : new RtcpStreamStat(cPtr, false);
      return ret;
    } 
  }

  public MathStat rttUsec {
    set {
      pjsua2PINVOKE.RtcpStat_rttUsec_set(swigCPtr, MathStat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.RtcpStat_rttUsec_get(swigCPtr);
      MathStat ret = (cPtr == global::System.IntPtr.Zero) ? null : new MathStat(cPtr, false);
      return ret;
    } 
  }

  public uint rtpTxLastTs {
    set {
      pjsua2PINVOKE.RtcpStat_rtpTxLastTs_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.RtcpStat_rtpTxLastTs_get(swigCPtr);
      return ret;
    } 
  }

  public ushort rtpTxLastSeq {
    set {
      pjsua2PINVOKE.RtcpStat_rtpTxLastSeq_set(swigCPtr, value);
    } 
    get {
      ushort ret = pjsua2PINVOKE.RtcpStat_rtpTxLastSeq_get(swigCPtr);
      return ret;
    } 
  }

  public MathStat rxIpdvUsec {
    set {
      pjsua2PINVOKE.RtcpStat_rxIpdvUsec_set(swigCPtr, MathStat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.RtcpStat_rxIpdvUsec_get(swigCPtr);
      MathStat ret = (cPtr == global::System.IntPtr.Zero) ? null : new MathStat(cPtr, false);
      return ret;
    } 
  }

  public MathStat rxRawJitterUsec {
    set {
      pjsua2PINVOKE.RtcpStat_rxRawJitterUsec_set(swigCPtr, MathStat.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.RtcpStat_rxRawJitterUsec_get(swigCPtr);
      MathStat ret = (cPtr == global::System.IntPtr.Zero) ? null : new MathStat(cPtr, false);
      return ret;
    } 
  }

  public RtcpSdes peerSdes {
    set {
      pjsua2PINVOKE.RtcpStat_peerSdes_set(swigCPtr, RtcpSdes.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.RtcpStat_peerSdes_get(swigCPtr);
      RtcpSdes ret = (cPtr == global::System.IntPtr.Zero) ? null : new RtcpSdes(cPtr, false);
      return ret;
    } 
  }

  public RtcpStat() : this(pjsua2PINVOKE.new_RtcpStat(), true) {
  }

}

}
