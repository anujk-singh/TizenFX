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

    internal class RenderTaskList : BaseHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RenderTaskList(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.RenderTaskList_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderTaskList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RenderTaskList() {
    DisposeQueue.Instance.Add(this);
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_RenderTaskList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }


  public RenderTaskList() : this(NDalicPINVOKE.new_RenderTaskList__SWIG_0(), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public static RenderTaskList DownCast(BaseHandle handle) {
    RenderTaskList ret = new RenderTaskList(NDalicPINVOKE.RenderTaskList_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RenderTaskList(RenderTaskList handle) : this(NDalicPINVOKE.new_RenderTaskList__SWIG_1(RenderTaskList.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public RenderTaskList Assign(RenderTaskList rhs) {
    RenderTaskList ret = new RenderTaskList(NDalicPINVOKE.RenderTaskList_Assign(swigCPtr, RenderTaskList.getCPtr(rhs)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RenderTask CreateTask() {
    RenderTask ret = new RenderTask(NDalicPINVOKE.RenderTaskList_CreateTask(swigCPtr), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveTask(RenderTask task) {
    NDalicPINVOKE.RenderTaskList_RemoveTask(swigCPtr, RenderTask.getCPtr(task));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint GetTaskCount() {
    uint ret = NDalicPINVOKE.RenderTaskList_GetTaskCount(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RenderTask GetTask(uint index) {
    RenderTask ret = new RenderTask(NDalicPINVOKE.RenderTaskList_GetTask(swigCPtr, index), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
