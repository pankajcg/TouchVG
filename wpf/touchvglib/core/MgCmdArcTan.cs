/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class MgCmdArcTan : MgCmdArc3P {
  private HandleRef swigCPtr;

  internal MgCmdArcTan(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgCmdArcTan_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgCmdArcTan obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCmdArcTan() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCmdArcTan(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgCmdArcTan(string name) : this(touchvgPINVOKE.new_MgCmdArcTan__SWIG_0(name), true) {
  }

  public MgCmdArcTan() : this(touchvgPINVOKE.new_MgCmdArcTan__SWIG_1(), true) {
  }

  public override void release() {
    touchvgPINVOKE.MgCmdArcTan_release(swigCPtr);
  }

}

}
