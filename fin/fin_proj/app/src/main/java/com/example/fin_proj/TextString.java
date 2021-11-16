package com.example.fin_proj;

import android.graphics.Color;
import android.view.View;
import android.view.ViewGroup;

public class TextString {
    private String t1,t2,t3,t4;  //t1:日期 t2:收入或支出 t4:total
    public TextString(){}





    public TextString(String text1, String text2,String text3)
    {
        this.t1 = text1;
        this.t2 = text2;
        this.t3 = text3;
       //this.t4 = text4;
    }

    public String getT1() {
        return t1;
    }

    public String getT2() {
        return t2;
    }

    public String getT3() {
        return t3;
    }

    //public String getT4() { return t4; }
}
