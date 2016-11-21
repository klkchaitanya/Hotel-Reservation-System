package alarm.android.app;

import java.util.Calendar;
import java.util.Locale;

import android.app.Activity;
import android.app.AlarmManager;
import android.app.PendingIntent;
import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.media.MediaPlayer;
import android.os.Bundle;
import android.text.Editable;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.TimePicker;
import android.widget.Toast;
import android.widget.ToggleButton;

public class AlarmActivity extends Activity implements OnClickListener{
    /** Called when the activity is first created. */
    
    String h,m="",ap="";
    int gh=0;
    String page;
    EditText et1,setlocket1;
    TextView tv1,tv2,mtv1,mtv2,mtv3,mtv4,mtv5,setlocktv1,setlocktv2;
    Button b1,b2,b3,b4,b5,b6,b7,b8,b9,b0,bl,br,check,bexit,tset;
    Button setlockb1,setlockb2,setlockb3,setlockb4,setlockb5,setlockb6,setlockb7,setlockb8,setlockb9,setlockb0,setlockbl,setlockbr,setlockok;
    MediaPlayer mp;
    TimePicker tp;
    SQLiteDatabase db;
    ToggleButton tb;
	   PendingIntent pint;
	   AlarmManager alm;

    int flag2=1;
    int flag;
    
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
       first(gh,m);
    }
    public void onDestroy()
    {
    	mp.stop();
    	super.onDestroy();
    	
    }
    public void onPause()
    {
    	
    	 super.onPause();
    	
    }
    
    public void onBackPressed()
    {
    	if(page.equals("setlockcode"))
		{first(gh,m);
		}
	if(page.equals("setalarm"))
		{first(gh,m);
		}
	if(page.equals("lockcode"))
		first(gh,m);
	
	if(page.equals("main"))
	{
		
    
	}
    }
     
    public void first(int o,String p)
    {
    	 setContentView(R.layout.main);
    	 page="main";
    	 mtv1=(TextView)findViewById(R.id.tv1);
    	 mtv2=(TextView)findViewById(R.id.tv2);
    	 mtv3=(TextView)findViewById(R.id.tv3);

    	 mtv4=(TextView)findViewById(R.id.tv4);
    	 mtv5=(TextView)findViewById(R.id.tv5);

    	 mtv1.setOnClickListener(this);
    	 mtv2.setOnClickListener(this);
    	 mtv3.setOnClickListener(this);
    	 mtv4.setOnClickListener(this);
    	 
    	 bexit=(Button)findViewById(R.id.bnext);
    	 tb=(ToggleButton)findViewById(R.id.toggleButton1);
    	 
    	
    	// bexit.setOnClickListener(this);
    	 
    	
    		 mtv5.setText("@"+Integer.toString(o)+":"+p+ap);
    		 
    	 
    	    db=openOrCreateDatabase("alarm.db",SQLiteDatabase.CREATE_IF_NECESSARY,null);
		    db.execSQL("create table if not exists wakeup2(code varchar)");
		    db.setVersion(1);
		    db.setLocale(Locale.getDefault());
		    db.close();
    	   
    	    db=openOrCreateDatabase("alarm.db",SQLiteDatabase.CREATE_IF_NECESSARY,null);
		    Cursor cr=db.query("wakeup2",null,null,null,null,null,null);
		    cr.moveToFirst();
		    if(cr.isAfterLast()==false)
		    {
		    	ContentValues cv=new ContentValues();
		    	cv.put("code","55555");
		    	db.insert("wakeup",null,cv);
		    	
		    }
		    db.close();
    }
    
    public void lockcode()
    {
    	flag=0;
    	flag2=1;
    	setContentView(R.layout.lockcode);
    	page="lockcode";
    	et1=(EditText)findViewById(R.id.editText1);
    
    	tv1=(TextView)findViewById(R.id.textView1);
    	tv2=(TextView)findViewById(R.id.textView2);
    	tv1.setText("Alarm Ringing!");
    	
    	et1.setHint("Enter Code");
    	
    	
    	//mp=MediaPlayer.create(getBaseContext(), R.raw.apple);
    	//mp.start();
    	//mp.setLooping(true);
    	
    	b1=(Button)findViewById(R.id.button1);
    	b2=(Button)findViewById(R.id.button2);
    	b3=(Button)findViewById(R.id.button3);
    	b4=(Button)findViewById(R.id.button4);
    	b5=(Button)findViewById(R.id.button5);
    	b6=(Button)findViewById(R.id.button6);
    	b7=(Button)findViewById(R.id.button7);
    	b8=(Button)findViewById(R.id.button8);
    	b9=(Button)findViewById(R.id.button9);
    	bl=(Button)findViewById(R.id.button10);
    	b0=(Button)findViewById(R.id.button11);
    	br=(Button)findViewById(R.id.button12);
    	check=(Button)findViewById(R.id.bcheck);
    	
    	b1.setOnClickListener(this);
    	b2.setOnClickListener(this);
    	b3.setOnClickListener(this);
    	b4.setOnClickListener(this);
    	b5.setOnClickListener(this);
    	b6.setOnClickListener(this);
    	b7.setOnClickListener(this);
    	b8.setOnClickListener(this);
    	b9.setOnClickListener(this);
    	b0.setOnClickListener(this);
    	bl.setOnClickListener(this);
    	br.setOnClickListener(this);
    	check.setOnClickListener(this);
    
    	
    }
    
    public void setlockcode()
    {
    	setContentView(R.layout.setlockcode);
    	page="setlockcode";
    	flag2=0;
    	
    	setlocket1=(EditText)findViewById(R.id.editText1);
    
    	setlocktv1=(TextView)findViewById(R.id.textView1);
    	setlocktv1.setText("Set new Code:");
    	
    	setlocket1.setHint("Enter Code");
    	
    	
    	setlockb1=(Button)findViewById(R.id.button1);
    	setlockb2=(Button)findViewById(R.id.button2);
    	setlockb3=(Button)findViewById(R.id.button3);
    	setlockb4=(Button)findViewById(R.id.button4);
    	setlockb5=(Button)findViewById(R.id.button5);
    	setlockb6=(Button)findViewById(R.id.button6);
    	setlockb7=(Button)findViewById(R.id.button7);
    	setlockb8=(Button)findViewById(R.id.button8);
    	setlockb9=(Button)findViewById(R.id.button9);
    	setlockbl=(Button)findViewById(R.id.button10);
    	setlockb0=(Button)findViewById(R.id.button11);
    	setlockbr=(Button)findViewById(R.id.button12);
    	setlockok=(Button)findViewById(R.id.bok);
    	
   	setlockb1.setOnClickListener(this);
    	setlockb2.setOnClickListener(this);
    	setlockb3.setOnClickListener(this);
    	setlockb4.setOnClickListener(this);
    	setlockb5.setOnClickListener(this);
    	setlockb6.setOnClickListener(this);
    	setlockb7.setOnClickListener(this);
    	setlockb8.setOnClickListener(this);
    	setlockb9.setOnClickListener(this);
    	setlockb0.setOnClickListener(this);
    	setlockbl.setOnClickListener(this);
    	setlockbr.setOnClickListener(this);
    	setlockok.setOnClickListener(this); 
    }
    
    public void setalarm()
    {
    	setContentView(R.layout.setalarm);
    	page="setalarm";    	
    	tp=(TimePicker)findViewById(R.id.timePicker1);
    	tset=(Button)findViewById(R.id.button1);
    	tset.setOnClickListener(this);
    }

	@Override
	public void onClick(View v) 
	{String val="";
	  flag=0;
		
	   if(v==b1||v==setlockb1)
			{val="1";

			}
	   if(v==b2||v==setlockb2)
			val="2";
	   if(v==b3||v==setlockb3)
			val="3";
	   if(v==b4||v==setlockb4)
			val="4";
	   if(v==b5||v==setlockb5)
			val="5";
	   if(v==b6||v==setlockb6)
			val="6";
	   if(v==b7||v==setlockb7)
			val="7";
	   if(v==b8||v==setlockb8)
			val="8";
	   if(v==b9||v==setlockb9)
			val="9";
	   if(v==b0||v==setlockb0)
			val="0";
	   if(v==bl||v==setlockbl)
	   {
            if(flag2==0)
            	  setlocket1.setText("");
            else 
		      et1.setText("");
		   
		     
	   }
	   if(v==br||v==setlockbr)
	   {
		   if(flag2==0)
			   {
			   Editable sed=setlocket1.getText();
			   if(sed.length()!=0)
			   {
				   sed.delete(sed.length()-1,sed.length());
				   setlocket1.setText(sed);
				   
			   }
			   }
		   else
		   {
		   Editable ed=et1.getText();
		   if(ed.length()!=0)
		   {
			   ed.delete(ed.length()-1,ed.length());
			   et1.setText(ed);
			   
		   }
		   }
	   }
	   if(v==check)
	   { flag=1;
	    db=openOrCreateDatabase("alarm.db",SQLiteDatabase.CREATE_IF_NECESSARY,null);
	      Cursor cr=db.query("wakeup2",null,null,null,null,null,null);
	      cr.moveToFirst();
	      while(cr.isAfterLast()==false)
	      {
				// Toast.makeText(getBaseContext(),cr.getString(0),Toast.LENGTH_SHORT).show();
		  if((cr.getString(0).equalsIgnoreCase(et1.getText().toString())))
		  {   stopService(new Intent(AlarmActivity.this,AlarmService.class));
			// Toast.makeText(getBaseContext(), "Alarm off!",Toast.LENGTH_SHORT).show();
		      tv1.setText("Alarm OFF!!    ");
		      et1.setText("");

		  }
	      
		  
		  else
			 Toast.makeText(getBaseContext(), "Wrong code!Try again",Toast.LENGTH_SHORT).show();
	      
		  cr.moveToNext();
	      }
	      db.close();
	   }
	   
	   if(v==setlockok)
	   {
		   flag=1;
		  
		  
		   db=openOrCreateDatabase("alarm.db",SQLiteDatabase.CREATE_IF_NECESSARY,null);
		   db.execSQL("delete from wakeup2");
		   db.close();
		   
		   db=openOrCreateDatabase("alarm.db",SQLiteDatabase.CREATE_IF_NECESSARY,null);
		   ContentValues cv=new ContentValues();
		   cv.put("code",setlocket1.getText().toString());
		   db.insert("wakeup2", null, cv);
		   db.close();

           
		   Toast.makeText(getBaseContext(), "NEW UNLOCK-CODE SET",Toast.LENGTH_SHORT).show();
 
	   }
	   if(v==bexit)
	   { flag=1;
		 System.exit(0);  
	   }
	   
	   if(v==mtv4)
	   {  flag=1;
		   lockcode();
	   
	   }
	   
	
	   if(v==tset)
	   {int 
		   gh1=0;
	     ap="AM";
		   //database code
			// Toast.makeText(getBaseContext(),tp.getCurrentHour().toString(),Toast.LENGTH_SHORT).show();
			 flag=1;
			 
			 
			 gh=tp.getCurrentHour();
			 m=tp.getCurrentMinute().toString();


			 if(gh>=12)
			 {
				 gh1=gh;
				 gh=gh-12;
			     ap="PM";	 
			 }
			 
			 
			 
		/*	db=openOrCreateDatabase("alarm.db",SQLiteDatabase.CREATE_IF_NECESSARY,null);
			ContentValues cv=new ContentValues();
			cv.put("hour",h);
			cv.put("minute",m);
			cv.put("status","1");
			db.insert("wakeup",null,cv);
			db.close(); */
			
			
		
			Calendar calendar = Calendar.getInstance();
			calendar.setTimeInMillis(System.currentTimeMillis());
			calendar.set(calendar.HOUR,gh);
			calendar.set(calendar.MINUTE,Integer.parseInt(m));
			calendar.set(calendar.SECOND,0);
			//calender.set(calendar.AM_PM,)
            
			Intent i=new Intent(AlarmActivity.this,AlarmService.class);
            
		 
            
            if(ap=="PM")
            {           
            	//Toast.makeText(AlarmActivity.this,"in if pm", Toast.LENGTH_LONG).show();
            i.putExtra("a",Integer.toString(gh1));
            }
            if(ap=="AM")
            {
            	//Toast.makeText(AlarmActivity.this,"in if am", Toast.LENGTH_LONG).show();
            	 i.putExtra("a",Integer.toString(gh));
            	 
            }
            i.putExtra("b",m);
            
          //  Toast.makeText(AlarmActivity.this,gh+" "+gh1+" "+m, Toast.LENGTH_LONG).show();

             pint=PendingIntent.getService(AlarmActivity.this,0,i,pint.FLAG_UPDATE_CURRENT);
            alm=(AlarmManager)getSystemService(ALARM_SERVICE);
            alm.set(AlarmManager.RTC_WAKEUP,calendar.getTimeInMillis(),pint);
            if(gh==0)
            	gh=12;
            Toast.makeText(AlarmActivity.this, "Alarm SET AT"+" "+Integer.toString(gh)+":"+m+ap, Toast.LENGTH_LONG).show();
            
			 
			first(gh,m);

	   }
	   if(v==mtv1)
	   {
		   setalarm();
		   flag=1;
	   }
	   
	   if(v==mtv3)
	   {   flag=3;
		   setlockcode();
	      
	      
	     
	   }
	   if(flag2==0)
	   {   flag=1;
		   setlocket1.append(val);
	   }
	   
	   if(flag==0)
	     et1.append(val);
	  
	}
}