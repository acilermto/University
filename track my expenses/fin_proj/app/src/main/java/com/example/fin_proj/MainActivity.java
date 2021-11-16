package com.example.fin_proj;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.os.Bundle;
import android.text.format.DateFormat;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Spinner;
import android.widget.TextView;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

import java.util.ArrayList;
import java.util.Calendar;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class MainActivity extends AppCompatActivity {


    Button b1,b2,b3; //新修山
    TextView et2,et3;
    Spinner sp1;
    String sp_1;
    ListView LV;

    Context context = this;

    int x_index = 0;
    int sum ;
    String x_select;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //定義
        b1 = findViewById(R.id.button1);
        b2 = findViewById(R.id.button2);
        b3 = findViewById(R.id.button3);

        sp1 = findViewById(R.id.choice);
        et2 = findViewById(R.id.editText2);
        et3 = findViewById(R.id.edit);

        LV = findViewById(R.id.ListV);




        Calendar mCal = Calendar.getInstance();
        //CharSequence s = DateFormat.format("yyyy-MM-dd kk:mm:ss", mCal.getTime());    // kk:24小時制, hh:12小時制
        CharSequence s = DateFormat.format("MM-dd kk", mCal.getTime());    // kk:24小時制, hh:12小時制
        String date = (String)s;
        et3.setText(date +"時");

        String[] which = getResources().getStringArray(R.array.which);
        int index =  sp1.getSelectedItemPosition();
        sp_1 = which[index];






        //連線數據庫
        FirebaseDatabase datab = FirebaseDatabase.getInstance();
        //父節點
        final DatabaseReference  myRef = datab.getReference("記帳本本");
        //子節點
        //final  DatabaseReference myRef2 = myRef.child("在這裡啦");
        final  DatabaseReference myRef2 = myRef.child(date);

        //讀取資料
        select_firebase(myRef2);

        //新修刪查







        //新
        b1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                x_index += 1;
                //sum += et2.getText();




                myRef2.child(String.valueOf(x_index)).setValue(new TextString(sp_1, et2.getText().toString(), et3.getText().toString()));
                select_firebase(myRef2);

                /*
                if(sp_1 == "支出")
                {
                    myRef2.child(String.valueOf(x_index)).setValue(new TextString(sp_1, "-"+et2.getText().toString(), et3.getText().toString(), "4"));
                    select_firebase(myRef2);
                }
                else
                {
                    myRef2.child(String.valueOf(x_index)).setValue(new TextString(sp_1, et2.getText().toString(), et3.getText().toString(), "4"));
                    select_firebase(myRef2);

                }

                 */
                /*
                TextView t4 = findViewById(R.id.text4);
                t4.setText(sp_1);
                */
               // Log.i("aaaaaaaaaaaaaaaaaaaaa",sp_1);12

            }
        });

        //修
        b2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {

                myRef2.child(x_select).setValue(new TextString(sp_1, et2.getText().toString(),et3.getText().toString()));
                select_firebase(myRef2);

            }
        });

        //山
        b3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v)
            {
                myRef2.child(x_select).removeValue();
                select_firebase(myRef2);

            }
        });

        //設定監聽器 當被點選案時...
        LV.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                TextView t1 = findViewById(R.id.text1);
                x_select = t1.getText().toString();

                TextView t2 = findViewById(R.id.text2);
                t1.setText(t2.getText().toString());

                //TextView t3_s = findViewById(R.id.text3);
                //t2.setText(t3_s.getText().toString());








            }
        });



    }





    private void select_firebase(DatabaseReference db)
    {
        final List<Map<String,Object>> items = new ArrayList<Map<String, Object>>();

        //設定單值事件監聽器
        db.addListenerForSingleValueEvent(new ValueEventListener() {
            @Override
            public void onDataChange(@NonNull DataSnapshot dataSnapshot) {

                //獲取總數
                //int x_number = (int)dataSnapshot.getChildrenCount();

                //

                for(DataSnapshot ds: dataSnapshot.getChildren())
                {
                    TextString usr_data = ds.getValue(TextString.class);
                    Map<String, Object> item = new HashMap<String, Object>();
                    item.put("id", ds.getKey());
                    item.put("z", usr_data.getT1());
                    item.put("z2", usr_data.getT2());
                    item.put("z3", usr_data.getT3());
                   // item.put("z4", usr_data.getT4());
                    items.add(item);

                    //抓取最後一筆
                    x_index = Integer.parseInt(ds.getKey());



                }
                SimpleAdapter SA = new SimpleAdapter(context, items, R.layout.textstring, new String[]{"id","z1","z2","z3"}, new int[]{R.id.text1, R.id.text2, R.id.text3,R.id.text4});
                LV.setAdapter(SA);
            }

            @Override
            public void onCancelled(@NonNull DatabaseError databaseError) {

            }
        });





    }
}
