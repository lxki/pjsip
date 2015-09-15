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

public class AccountNatConfig : PersistentObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AccountNatConfig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.AccountNatConfig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AccountNatConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AccountNatConfig() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_AccountNatConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public pjsua_stun_use sipStunUse {
    set {
      pjsua2PINVOKE.AccountNatConfig_sipStunUse_set(swigCPtr, (int)value);
    } 
    get {
      pjsua_stun_use ret = (pjsua_stun_use)pjsua2PINVOKE.AccountNatConfig_sipStunUse_get(swigCPtr);
      return ret;
    } 
  }

  public pjsua_stun_use mediaStunUse {
    set {
      pjsua2PINVOKE.AccountNatConfig_mediaStunUse_set(swigCPtr, (int)value);
    } 
    get {
      pjsua_stun_use ret = (pjsua_stun_use)pjsua2PINVOKE.AccountNatConfig_mediaStunUse_get(swigCPtr);
      return ret;
    } 
  }

  public bool iceEnabled {
    set {
      pjsua2PINVOKE.AccountNatConfig_iceEnabled_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountNatConfig_iceEnabled_get(swigCPtr);
      return ret;
    } 
  }

  public int iceMaxHostCands {
    set {
      pjsua2PINVOKE.AccountNatConfig_iceMaxHostCands_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_iceMaxHostCands_get(swigCPtr);
      return ret;
    } 
  }

  public bool iceAggressiveNomination {
    set {
      pjsua2PINVOKE.AccountNatConfig_iceAggressiveNomination_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountNatConfig_iceAggressiveNomination_get(swigCPtr);
      return ret;
    } 
  }

  public uint iceNominatedCheckDelayMsec {
    set {
      pjsua2PINVOKE.AccountNatConfig_iceNominatedCheckDelayMsec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AccountNatConfig_iceNominatedCheckDelayMsec_get(swigCPtr);
      return ret;
    } 
  }

  public int iceWaitNominationTimeoutMsec {
    set {
      pjsua2PINVOKE.AccountNatConfig_iceWaitNominationTimeoutMsec_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_iceWaitNominationTimeoutMsec_get(swigCPtr);
      return ret;
    } 
  }

  public bool iceNoRtcp {
    set {
      pjsua2PINVOKE.AccountNatConfig_iceNoRtcp_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountNatConfig_iceNoRtcp_get(swigCPtr);
      return ret;
    } 
  }

  public bool iceAlwaysUpdate {
    set {
      pjsua2PINVOKE.AccountNatConfig_iceAlwaysUpdate_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountNatConfig_iceAlwaysUpdate_get(swigCPtr);
      return ret;
    } 
  }

  public bool turnEnabled {
    set {
      pjsua2PINVOKE.AccountNatConfig_turnEnabled_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountNatConfig_turnEnabled_get(swigCPtr);
      return ret;
    } 
  }

  public string turnServer {
    set {
      pjsua2PINVOKE.AccountNatConfig_turnServer_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AccountNatConfig_turnServer_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public pj_turn_tp_type turnConnType {
    set {
      pjsua2PINVOKE.AccountNatConfig_turnConnType_set(swigCPtr, (int)value);
    } 
    get {
      pj_turn_tp_type ret = (pj_turn_tp_type)pjsua2PINVOKE.AccountNatConfig_turnConnType_get(swigCPtr);
      return ret;
    } 
  }

  public string turnUserName {
    set {
      pjsua2PINVOKE.AccountNatConfig_turnUserName_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AccountNatConfig_turnUserName_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int turnPasswordType {
    set {
      pjsua2PINVOKE.AccountNatConfig_turnPasswordType_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_turnPasswordType_get(swigCPtr);
      return ret;
    } 
  }

  public string turnPassword {
    set {
      pjsua2PINVOKE.AccountNatConfig_turnPassword_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AccountNatConfig_turnPassword_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int contactRewriteUse {
    set {
      pjsua2PINVOKE.AccountNatConfig_contactRewriteUse_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_contactRewriteUse_get(swigCPtr);
      return ret;
    } 
  }

  public int contactRewriteMethod {
    set {
      pjsua2PINVOKE.AccountNatConfig_contactRewriteMethod_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_contactRewriteMethod_get(swigCPtr);
      return ret;
    } 
  }

  public int contactUseSrcPort {
    set {
      pjsua2PINVOKE.AccountNatConfig_contactUseSrcPort_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_contactUseSrcPort_get(swigCPtr);
      return ret;
    } 
  }

  public int viaRewriteUse {
    set {
      pjsua2PINVOKE.AccountNatConfig_viaRewriteUse_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_viaRewriteUse_get(swigCPtr);
      return ret;
    } 
  }

  public int sdpNatRewriteUse {
    set {
      pjsua2PINVOKE.AccountNatConfig_sdpNatRewriteUse_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_sdpNatRewriteUse_get(swigCPtr);
      return ret;
    } 
  }

  public int sipOutboundUse {
    set {
      pjsua2PINVOKE.AccountNatConfig_sipOutboundUse_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountNatConfig_sipOutboundUse_get(swigCPtr);
      return ret;
    } 
  }

  public string sipOutboundInstanceId {
    set {
      pjsua2PINVOKE.AccountNatConfig_sipOutboundInstanceId_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AccountNatConfig_sipOutboundInstanceId_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string sipOutboundRegId {
    set {
      pjsua2PINVOKE.AccountNatConfig_sipOutboundRegId_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AccountNatConfig_sipOutboundRegId_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint udpKaIntervalSec {
    set {
      pjsua2PINVOKE.AccountNatConfig_udpKaIntervalSec_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.AccountNatConfig_udpKaIntervalSec_get(swigCPtr);
      return ret;
    } 
  }

  public string udpKaData {
    set {
      pjsua2PINVOKE.AccountNatConfig_udpKaData_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.AccountNatConfig_udpKaData_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public override void readObject(ContainerNode node) {
    pjsua2PINVOKE.AccountNatConfig_readObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void writeObject(ContainerNode node) {
    pjsua2PINVOKE.AccountNatConfig_writeObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public AccountNatConfig() : this(pjsua2PINVOKE.new_AccountNatConfig(), true) {
  }

}

}
