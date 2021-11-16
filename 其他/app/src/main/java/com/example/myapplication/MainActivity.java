package com.example.myapplication;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }

    public void test(View V)
    {
        TextView aaa = findViewById(R.id.morning);
        aaa.setText("一起吃早餐吧:D");
    }
    public void test2(View V)
    {
        TextView aaa = findViewById(R.id.morning);
        aaa.setText("路上小心!");
    }
    int size = 30;
    public void bigger(View V)
    {
        TextView aaa;
        aaa = findViewById(R.id.morning);
        aaa.setTextSize(++size);
    }
    public void small(View V)
    {
        TextView aaa = findViewById(R.id.morning);
        aaa.setTextSize(--size);
    }

    public void name1(View V)
    {
       EditText edt1 = findViewById(R.id.name);
        String str = edt1.getText().toString();
        TextView aaa = findViewById(R.id.morning);
        aaa.setText(str);

    }



}
