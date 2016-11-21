package alarm.android.app;

import java.util.Date;

import android.app.Notification;
import android.app.NotificationManager;
import android.app.PendingIntent;
import android.app.Service;
import android.content.Context;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.IBinder;
import android.widget.Toast;

public class AlarmService extends Service{

	
	
	SQLiteDatabase db;
	MediaPlayer mp;
	private NotificationManager nm;
	private Notification n;
	public IBinder onBind(Intent arg0) {
		// TODO Auto-generated method stub
		return null;
	}
	
	public void onCreate()
	{
		mp=MediaPlayer.create(getBaseContext(), R.raw.apple);
	 	//Toast.makeText(this, "Alarm Service Started", Toast.LENGTH_LONG).show();
	}
	
	AlarmActivity alact=new AlarmActivity();
	
	public void onStart(Intent intent,int startid)
	{
		super.onStart(intent, startid);
	    String h1=null,m1=null,s1=null;
	    
	    String a=intent.getStringExtra("a");
	    String b=intent.getStringExtra("b");

		
		
	      Date dt=new Date();
	      int h2=dt.getHours();
	      int m2=dt.getMinutes();
	      String hh=Integer.toString(dt.getHours());
	      String mm=Integer.toString(dt.getMinutes());
    	//  Toast.makeText(getBaseContext(),a+b+hh+mm,Toast.LENGTH_SHORT).show(); 


         if(a.equals(hh))
         {
			
    	  Toast.makeText(getBaseContext(),"Alarm-Ringing!!",Toast.LENGTH_SHORT).show(); 
    	  
    	 
    	
    	  
    	 nm=(NotificationManager)getSystemService(Context.NOTIFICATION_SERVICE);
    	  n=new Notification(R.drawable.alarmicon,"Alarm Ringing!!",System.currentTimeMillis());
    	  Context con=getApplicationContext();
    	  Intent mint=new Intent(Intent.ACTION_VIEW,Uri.parse("abc"));
    	  mint.setClass(this,AlarmActivity.class);
    	  PendingIntent pendingIntent= PendingIntent.getActivity(AlarmService.this,0,mint,Intent.FLAG_ACTIVITY_NEW_TASK);
    	//  n.defaults |= Notification.DEFAULT_SOUND;
    	   n.flags |= Notification.FLAG_NO_CLEAR;
    	  n.flags=Notification.DEFAULT_LIGHTS;
    	   n.setLatestEventInfo(con,"Chaitu's Alarm","Alarm is ringing!!Tap here to OFF..",pendingIntent);
    	   
    	   nm.notify(1,n);
    	  
    	/*   Intent in = new Intent();
     	  in.setClass(this, AlarmActivity.class);
     	  
     	  in.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
     	 startActivity(in); */
     	  // PendingIntent pendint=PendingIntent.getActivity(this.getApplicationContext(),0, in,0);
     	  //n.contentIntent=pendint;
     	  

    	  
    	  
    	  mp.start();
    	  mp.setLooping(true);
        // alact.lockcode();
	      
	    
		
		//AlarmActivity a=new AlarmActivity();
		//a.lockcode();
         }
	}
	
	public void onDestroy()
	{
	  
	  super.onDestroy();
	  mp.setLooping(false);
	  mp.stop();
	  mp.release();
	  nm.cancel(1);
	  
	  Toast.makeText(getBaseContext(),"Alarm-Off!!",Toast.LENGTH_SHORT).show(); 
	 

	}

}
