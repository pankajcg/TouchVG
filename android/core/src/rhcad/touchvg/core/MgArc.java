/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package rhcad.touchvg.core;

public class MgArc extends MgBaseShape {
  private long swigCPtr;

  protected MgArc(long cPtr, boolean cMemoryOwn) {
    super(touchvgJNI.MgArc_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MgArc obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        touchvgJNI.delete_MgArc(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public MgArc() {
    this(touchvgJNI.new_MgArc(), true);
  }

  public static MgArc create() {
    long cPtr = touchvgJNI.MgArc_create();
    return (cPtr == 0) ? null : new MgArc(cPtr, false);
  }

  public static int Type() {
    return touchvgJNI.MgArc_Type();
  }

  public MgObject clone() {
    long cPtr = touchvgJNI.MgArc_clone(swigCPtr, this);
    return (cPtr == 0) ? null : new MgObject(cPtr, false);
  }

  public void copy(MgObject src) {
    touchvgJNI.MgArc_copy(swigCPtr, this, MgObject.getCPtr(src), src);
  }

  public void release() {
    touchvgJNI.MgArc_release(swigCPtr, this);
  }

  public boolean equals(MgObject src) {
    return touchvgJNI.MgArc_equals(swigCPtr, this, MgObject.getCPtr(src), src);
  }

  public int getType() {
    return touchvgJNI.MgArc_getType(swigCPtr, this);
  }

  public boolean isKindOf(int type) {
    return touchvgJNI.MgArc_isKindOf(swigCPtr, this, type);
  }

  public Box2d getExtent() {
    return new Box2d(touchvgJNI.MgArc_getExtent(swigCPtr, this), true);
  }

  public void update() {
    touchvgJNI.MgArc_update(swigCPtr, this);
  }

  public void transform(Matrix2d mat) {
    touchvgJNI.MgArc_transform(swigCPtr, this, Matrix2d.getCPtr(mat), mat);
  }

  public void clear() {
    touchvgJNI.MgArc_clear(swigCPtr, this);
  }

  public void clearCachedData() {
    touchvgJNI.MgArc_clearCachedData(swigCPtr, this);
  }

  public int getPointCount() {
    return touchvgJNI.MgArc_getPointCount(swigCPtr, this);
  }

  public Point2d getPoint(int index) {
    return new Point2d(touchvgJNI.MgArc_getPoint(swigCPtr, this, index), true);
  }

  public void setPoint(int index, Point2d pt) {
    touchvgJNI.MgArc_setPoint(swigCPtr, this, index, Point2d.getCPtr(pt), pt);
  }

  public boolean isClosed() {
    return touchvgJNI.MgArc_isClosed(swigCPtr, this);
  }

  public boolean hitTestBox(Box2d rect) {
    return touchvgJNI.MgArc_hitTestBox(swigCPtr, this, Box2d.getCPtr(rect), rect);
  }

  public boolean draw(int mode, GiGraphics gs, GiContext ctx, int segment) {
    return touchvgJNI.MgArc_draw(swigCPtr, this, mode, GiGraphics.getCPtr(gs), gs, GiContext.getCPtr(ctx), ctx, segment);
  }

  public boolean save(MgStorage s) {
    return touchvgJNI.MgArc_save(swigCPtr, this, MgStorage.getCPtr(s), s);
  }

  public boolean load(MgShapeFactory factory, MgStorage s) {
    return touchvgJNI.MgArc_load(swigCPtr, this, MgShapeFactory.getCPtr(factory), factory, MgStorage.getCPtr(s), s);
  }

  public int getHandleCount() {
    return touchvgJNI.MgArc_getHandleCount(swigCPtr, this);
  }

  public Point2d getHandlePoint(int index) {
    return new Point2d(touchvgJNI.MgArc_getHandlePoint(swigCPtr, this, index), true);
  }

  public boolean setHandlePoint(int index, Point2d pt, float tol) {
    return touchvgJNI.MgArc_setHandlePoint(swigCPtr, this, index, Point2d.getCPtr(pt), pt, tol);
  }

  public boolean isHandleFixed(int index) {
    return touchvgJNI.MgArc_isHandleFixed(swigCPtr, this, index);
  }

  public int getHandleType(int index) {
    return touchvgJNI.MgArc_getHandleType(swigCPtr, this, index);
  }

  public boolean offset(Vector2d vec, int segment) {
    return touchvgJNI.MgArc_offset(swigCPtr, this, Vector2d.getCPtr(vec), vec, segment);
  }

  public float hitTest(Point2d pt, float tol, MgHitResult res) {
    return touchvgJNI.MgArc_hitTest(swigCPtr, this, Point2d.getCPtr(pt), pt, tol, MgHitResult.getCPtr(res), res);
  }

  public Point2d getCenter() {
    return new Point2d(touchvgJNI.MgArc_getCenter(swigCPtr, this), true);
  }

  public Point2d getStartPoint() {
    return new Point2d(touchvgJNI.MgArc_getStartPoint(swigCPtr, this), true);
  }

  public Point2d getEndPoint() {
    return new Point2d(touchvgJNI.MgArc_getEndPoint(swigCPtr, this), true);
  }

  public Point2d getMidPoint() {
    return new Point2d(touchvgJNI.MgArc_getMidPoint(swigCPtr, this), true);
  }

  public float getRadius() {
    return touchvgJNI.MgArc_getRadius(swigCPtr, this);
  }

  public float getStartAngle() {
    return touchvgJNI.MgArc_getStartAngle(swigCPtr, this);
  }

  public float getEndAngle() {
    return touchvgJNI.MgArc_getEndAngle(swigCPtr, this);
  }

  public float getSweepAngle() {
    return touchvgJNI.MgArc_getSweepAngle(swigCPtr, this);
  }

  public Vector2d getStartTangent() {
    return new Vector2d(touchvgJNI.MgArc_getStartTangent(swigCPtr, this), true);
  }

  public Vector2d getEndTangent() {
    return new Vector2d(touchvgJNI.MgArc_getEndTangent(swigCPtr, this), true);
  }

  public boolean setStartMidEnd(Point2d start, Point2d point, Point2d end) {
    return touchvgJNI.MgArc_setStartMidEnd(swigCPtr, this, Point2d.getCPtr(start), start, Point2d.getCPtr(point), point, Point2d.getCPtr(end), end);
  }

  public boolean setCenterStartEnd(Point2d center, Point2d start) {
    return touchvgJNI.MgArc_setCenterStartEnd__SWIG_0(swigCPtr, this, Point2d.getCPtr(center), center, Point2d.getCPtr(start), start);
  }

  public boolean setCenterStartEnd(Point2d center, Point2d start, Point2d end) {
    return touchvgJNI.MgArc_setCenterStartEnd__SWIG_1(swigCPtr, this, Point2d.getCPtr(center), center, Point2d.getCPtr(start), start, Point2d.getCPtr(end), end);
  }

  public boolean setTanStartEnd(Vector2d startTan, Point2d start, Point2d end) {
    return touchvgJNI.MgArc_setTanStartEnd(swigCPtr, this, Vector2d.getCPtr(startTan), startTan, Point2d.getCPtr(start), start, Point2d.getCPtr(end), end);
  }

  public boolean setCenterRadius(Point2d center, float radius, float startAngle, float sweepAngle) {
    return touchvgJNI.MgArc_setCenterRadius(swigCPtr, this, Point2d.getCPtr(center), center, radius, startAngle, sweepAngle);
  }

  public boolean isCurve() {
    return touchvgJNI.MgArc_isCurve(swigCPtr, this);
  }

}
