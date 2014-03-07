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

public class MgPlaying : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgPlaying(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgPlaying obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgPlaying() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgPlaying(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public MgPlaying() : this(touchvgPINVOKE.new_MgPlaying(), true) {
  }

  public int acquireShapes() {
    int ret = touchvgPINVOKE.MgPlaying_acquireShapes(swigCPtr);
    return ret;
  }

  public static void releaseShapes(int shapes) {
    touchvgPINVOKE.MgPlaying_releaseShapes(shapes);
  }

  public int getShapesForEdit() {
    int ret = touchvgPINVOKE.MgPlaying_getShapesForEdit(swigCPtr);
    return ret;
  }

  public void submitShapes() {
    touchvgPINVOKE.MgPlaying_submitShapes(swigCPtr);
  }

}

}
