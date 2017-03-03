//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Tizen.NUI {

    public class KeyInputFocusManager : BaseHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal KeyInputFocusManager(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.KeyInputFocusManager_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(KeyInputFocusManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~KeyInputFocusManager() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_KeyInputFocusManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public KeyInputFocusManager() : this(NDalicPINVOKE.new_KeyInputFocusManager(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public static KeyInputFocusManager Get() {
    KeyInputFocusManager ret = new KeyInputFocusManager(NDalicPINVOKE.KeyInputFocusManager_Get(), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFocus(View control) {
    NDalicPINVOKE.KeyInputFocusManager_SetFocus(swigCPtr, View.getCPtr(control));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public View GetCurrentFocusControl() {
    View ret = new View(NDalicPINVOKE.KeyInputFocusManager_GetCurrentFocusControl(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveFocus(View control) {
    NDalicPINVOKE.KeyInputFocusManager_RemoveFocus(swigCPtr, View.getCPtr(control));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsKeyboardListener(View control) {
    bool ret = NDalicPINVOKE.KeyInputFocusManager_IsKeyboardListener(swigCPtr, View.getCPtr(control));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__Control_Dali__Toolkit__ControlF_t KeyInputFocusChangedSignal() {
    SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__Control_Dali__Toolkit__ControlF_t ret = new SWIGTYPE_p_Dali__SignalT_void_fDali__Toolkit__Control_Dali__Toolkit__ControlF_t(NDalicPINVOKE.KeyInputFocusManager_KeyInputFocusChangedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal KeyEventSignal UnhandledKeyEventSignal() {
    KeyEventSignal ret = new KeyEventSignal(NDalicPINVOKE.KeyInputFocusManager_UnhandledKeyEventSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
