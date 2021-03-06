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

public class MgArc : MgBaseShape {
  private HandleRef swigCPtr;

  internal MgArc(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgArc_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgArc obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgArc() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgArc(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgArc() : this(touchvgPINVOKE.new_MgArc(), true) {
  }

  public static MgArc create() {
    IntPtr cPtr = touchvgPINVOKE.MgArc_create();
    MgArc ret = (cPtr == IntPtr.Zero) ? null : new MgArc(cPtr, false);
    return ret;
  }

  public new static int Type() {
    int ret = touchvgPINVOKE.MgArc_Type();
    return ret;
  }

  public override MgObject clone() {
    IntPtr cPtr = touchvgPINVOKE.MgArc_clone(swigCPtr);
    MgObject ret = (cPtr == IntPtr.Zero) ? null : new MgObject(cPtr, false);
    return ret;
  }

  public override void copy(MgObject src) {
    touchvgPINVOKE.MgArc_copy(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void release() {
    touchvgPINVOKE.MgArc_release(swigCPtr);
  }

  public override bool equals(MgObject src) {
    bool ret = touchvgPINVOKE.MgArc_equals(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getType() {
    int ret = touchvgPINVOKE.MgArc_getType(swigCPtr);
    return ret;
  }

  public override bool isKindOf(int type) {
    bool ret = touchvgPINVOKE.MgArc_isKindOf(swigCPtr, type);
    return ret;
  }

  public override Box2d getExtent() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgArc_getExtent(swigCPtr), true);
    return ret;
  }

  public override void update() {
    touchvgPINVOKE.MgArc_update(swigCPtr);
  }

  public override void transform(Matrix2d mat) {
    touchvgPINVOKE.MgArc_transform(swigCPtr, Matrix2d.getCPtr(mat));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void clear() {
    touchvgPINVOKE.MgArc_clear(swigCPtr);
  }

  public override void clearCachedData() {
    touchvgPINVOKE.MgArc_clearCachedData(swigCPtr);
  }

  public override int getPointCount() {
    int ret = touchvgPINVOKE.MgArc_getPointCount(swigCPtr);
    return ret;
  }

  public override Point2d getPoint(int index) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgArc_getPoint(swigCPtr, index), true);
    return ret;
  }

  public override void setPoint(int index, Point2d pt) {
    touchvgPINVOKE.MgArc_setPoint(swigCPtr, index, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool isClosed() {
    bool ret = touchvgPINVOKE.MgArc_isClosed(swigCPtr);
    return ret;
  }

  public override bool hitTestBox(Box2d rect) {
    bool ret = touchvgPINVOKE.MgArc_hitTestBox(swigCPtr, Box2d.getCPtr(rect));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool draw(int mode, GiGraphics gs, GiContext ctx, int segment) {
    bool ret = touchvgPINVOKE.MgArc_draw(swigCPtr, mode, GiGraphics.getCPtr(gs), GiContext.getCPtr(ctx), segment);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool save(MgStorage s) {
    bool ret = touchvgPINVOKE.MgArc_save(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public override bool load(MgShapeFactory factory, MgStorage s) {
    bool ret = touchvgPINVOKE.MgArc_load(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s));
    return ret;
  }

  public override int getHandleCount() {
    int ret = touchvgPINVOKE.MgArc_getHandleCount(swigCPtr);
    return ret;
  }

  public override Point2d getHandlePoint(int index) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgArc_getHandlePoint(swigCPtr, index), true);
    return ret;
  }

  public override bool setHandlePoint(int index, Point2d pt, float tol) {
    bool ret = touchvgPINVOKE.MgArc_setHandlePoint(swigCPtr, index, Point2d.getCPtr(pt), tol);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isHandleFixed(int index) {
    bool ret = touchvgPINVOKE.MgArc_isHandleFixed(swigCPtr, index);
    return ret;
  }

  public override int getHandleType(int index) {
    int ret = touchvgPINVOKE.MgArc_getHandleType(swigCPtr, index);
    return ret;
  }

  public override bool offset(Vector2d vec, int segment) {
    bool ret = touchvgPINVOKE.MgArc_offset(swigCPtr, Vector2d.getCPtr(vec), segment);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float hitTest(Point2d pt, float tol, MgHitResult res) {
    float ret = touchvgPINVOKE.MgArc_hitTest(swigCPtr, Point2d.getCPtr(pt), tol, MgHitResult.getCPtr(res));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point2d getCenter() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgArc_getCenter(swigCPtr), true);
    return ret;
  }

  public Point2d getStartPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgArc_getStartPoint(swigCPtr), true);
    return ret;
  }

  public Point2d getEndPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgArc_getEndPoint(swigCPtr), true);
    return ret;
  }

  public Point2d getMidPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgArc_getMidPoint(swigCPtr), true);
    return ret;
  }

  public float getRadius() {
    float ret = touchvgPINVOKE.MgArc_getRadius(swigCPtr);
    return ret;
  }

  public float getStartAngle() {
    float ret = touchvgPINVOKE.MgArc_getStartAngle(swigCPtr);
    return ret;
  }

  public float getEndAngle() {
    float ret = touchvgPINVOKE.MgArc_getEndAngle(swigCPtr);
    return ret;
  }

  public float getSweepAngle() {
    float ret = touchvgPINVOKE.MgArc_getSweepAngle(swigCPtr);
    return ret;
  }

  public Vector2d getStartTangent() {
    Vector2d ret = new Vector2d(touchvgPINVOKE.MgArc_getStartTangent(swigCPtr), true);
    return ret;
  }

  public Vector2d getEndTangent() {
    Vector2d ret = new Vector2d(touchvgPINVOKE.MgArc_getEndTangent(swigCPtr), true);
    return ret;
  }

  public bool setStartMidEnd(Point2d start, Point2d point, Point2d end) {
    bool ret = touchvgPINVOKE.MgArc_setStartMidEnd(swigCPtr, Point2d.getCPtr(start), Point2d.getCPtr(point), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setCenterStartEnd(Point2d center, Point2d start) {
    bool ret = touchvgPINVOKE.MgArc_setCenterStartEnd__SWIG_0(swigCPtr, Point2d.getCPtr(center), Point2d.getCPtr(start));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setCenterStartEnd(Point2d center, Point2d start, Point2d end) {
    bool ret = touchvgPINVOKE.MgArc_setCenterStartEnd__SWIG_1(swigCPtr, Point2d.getCPtr(center), Point2d.getCPtr(start), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setTanStartEnd(Vector2d startTan, Point2d start, Point2d end) {
    bool ret = touchvgPINVOKE.MgArc_setTanStartEnd(swigCPtr, Vector2d.getCPtr(startTan), Point2d.getCPtr(start), Point2d.getCPtr(end));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setCenterRadius(Point2d center, float radius, float startAngle, float sweepAngle) {
    bool ret = touchvgPINVOKE.MgArc_setCenterRadius(swigCPtr, Point2d.getCPtr(center), radius, startAngle, sweepAngle);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool isCurve() {
    bool ret = touchvgPINVOKE.MgArc_isCurve(swigCPtr);
    return ret;
  }

}

}
