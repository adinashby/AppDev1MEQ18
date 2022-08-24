package com.example.myfirstproject;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    public void keyPressed(View view) {
        EditText editText = (EditText) findViewById(R.id.nameEditText);

        Log.i("Info", "The button was pressed.");
        Log.i("Values", editText.getText().toString());

        Toast.makeText(getApplicationContext(), "Button pressed!!", Toast.LENGTH_LONG).show();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
}