// Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
// PROPRIETARY/CONFIDENTIAL 
// This software is the confidential and proprietary
// information of SAMSUNG ELECTRONICS ("Confidential Information"). You shall
// not disclose such Confidential Information and shall use it only in
// accordance with the terms of the license agreement you entered into with
// SAMSUNG ELECTRONICS. SAMSUNG make no representations or warranties about the
// suitability of the software, either express or implied, including but not
// limited to the implied warranties of merchantability, fitness for a
// particular purpose, or non-infringement. SAMSUNG shall not be liable for any
// damages suffered by licensee as a result of using, modifying or distributing
// this software or its derivatives.

// Copyright (c) 2017 Samsung Electronics Co., Ltd.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
// Some have been manually changed


namespace Tizen.NUI
{

    public class Window : BaseHandle
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal Window(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Window_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Window obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~Window()
        {
            DisposeQueue.Instance.Add(this);
        }

        public override void Dispose()
        {
            if (!Stage.IsInstalled())
            {
                DisposeQueue.Instance.Add(this);
                return;
            }

            lock (this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_Window(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
                base.Dispose();
            }
        }


        public Window(Rectangle windowPosition, string name, bool isTransparent) : this(NDalicPINVOKE.Window_New__SWIG_0(Rectangle.getCPtr(windowPosition), name, isTransparent), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        public Window(Rectangle windowPosition, string name) : this(NDalicPINVOKE.Window_New__SWIG_1(Rectangle.getCPtr(windowPosition), name), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        public Window(Rectangle windowPosition, string name, string className, bool isTransparent) : this(NDalicPINVOKE.Window_New__SWIG_2(Rectangle.getCPtr(windowPosition), name, className, isTransparent), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        public Window(Rectangle windowPosition, string name, string className) : this(NDalicPINVOKE.Window_New__SWIG_3(Rectangle.getCPtr(windowPosition), name, className), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        internal Window(Window handle) : this(NDalicPINVOKE.new_Window__SWIG_1(Window.getCPtr(handle)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal Window Assign(Window rhs)
        {
            Window ret = new Window(NDalicPINVOKE.Window_Assign(swigCPtr, Window.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void ShowIndicator(Window.IndicatorVisibleMode visibleMode)
        {
            NDalicPINVOKE.Window_ShowIndicator(swigCPtr, (int)visibleMode);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetIndicatorBgOpacity(Window.IndicatorBgOpacity opacity)
        {
            NDalicPINVOKE.Window_SetIndicatorBgOpacity(swigCPtr, (int)opacity);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RotateIndicator(Window.WindowOrientation orientation)
        {
            NDalicPINVOKE.Window_RotateIndicator(swigCPtr, (int)orientation);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void SetClass(string name, string klass)
        {
            NDalicPINVOKE.Window_SetClass(swigCPtr, name, klass);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Raise()
        {
            NDalicPINVOKE.Window_Raise(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Lower()
        {
            NDalicPINVOKE.Window_Lower(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Activate()
        {
            NDalicPINVOKE.Window_Activate(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void AddAvailableOrientation(Window.WindowOrientation orientation)
        {
            NDalicPINVOKE.Window_AddAvailableOrientation(swigCPtr, (int)orientation);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void RemoveAvailableOrientation(Window.WindowOrientation orientation)
        {
            NDalicPINVOKE.Window_RemoveAvailableOrientation(swigCPtr, (int)orientation);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal void SetPreferredOrientation(Window.WindowOrientation orientation)
        {
            NDalicPINVOKE.Window_SetPreferredOrientation(swigCPtr, (int)orientation);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal Window.WindowOrientation GetPreferredOrientation()
        {
            Window.WindowOrientation ret = (Window.WindowOrientation)NDalicPINVOKE.Window_GetPreferredOrientation(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal DragAndDropDetector GetDragAndDropDetector()
        {
            DragAndDropDetector ret = new DragAndDropDetector(NDalicPINVOKE.Window_GetDragAndDropDetector(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal Any GetNativeHandle()
        {
            Any ret = new Any(NDalicPINVOKE.Window_GetNativeHandle(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal SWIGTYPE_p_Dali__SignalT_void_fboolF_t IndicatorVisibilityChangedSignal()
        {
            SWIGTYPE_p_Dali__SignalT_void_fboolF_t ret = new SWIGTYPE_p_Dali__SignalT_void_fboolF_t(NDalicPINVOKE.Window_IndicatorVisibilityChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public enum WindowOrientation
        {
            Portrait = 0,
            Landscape = 90,
            PortraitInverse = 180,
            LandscapeInverse = 270
        }

        public enum IndicatorBgOpacity
        {
            Opaque = 100,
            Translucent = 50,
            Transparent = 0
        }

        public enum IndicatorVisibleMode
        {
            Invisible = 0,
            Visible = 1,
            Auto = 2
        }

    }

}
