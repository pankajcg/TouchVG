// Copyright (c) 2013, https://github.com/rhcad/touchvg

package touchvg.demo1;

import rhcad.touchvg.IGraphView;
import rhcad.touchvg.IGraphView.OnSelectionChangedListener;
import rhcad.touchvg.view.ShapeView;
import android.animation.ObjectAnimator;
import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.ViewGroup;

public class AnimationActivity1 extends ExampleActivity1 {

    @Override
    protected void createGraphView(Bundle savedInstanceState) {
        setContentView(R.layout.activity_animation1);

        final ViewGroup layout = (ViewGroup) this.findViewById(R.id.frame);
        hlp.createShapeView(this, layout).setBackgroundColor(Color.WHITE);

        hlp.getGraphView().setContextActionEnabled(false);
        hlp.getGraphView().setOnSelectionChangedListener(new OnSelectionChangedListener() {
            @Override
            public void onSelectionChanged(IGraphView view) {
                int id = hlp.getSelectedShapeID();
                final View v = ((ShapeView) view).findShapeView(id);
                if (v != null) {
                    ObjectAnimator animator = ObjectAnimator.ofFloat(v, "alpha", 0, 1);
                    animator.setRepeatCount(10);
                    animator.start();
                }
            }
        });
    }

    @Override
    protected void initButtons() {
        this.findViewById(R.id.loadBtn).setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View v) {
                hlp.setImagePath(PATH);
                hlp.loadFromFile(VGFILE, true);
                hlp.setCommand("select");
            }
        });
    }
}
