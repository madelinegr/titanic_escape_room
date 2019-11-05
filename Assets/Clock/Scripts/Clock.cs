using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Clock : MonoBehaviour {

	//-- set start time 00:00
    private int minutes = 0;
    private int hour = 11;
	private int seconds = 0;
	private bool realTime=false;
    private int FinalHour=12;
    private int FinalMinutes=0;
    private int FinalSeconds=0;
    public bool GameOver=true;
    
    public Canvas canvas;
    

    public GameObject pointerSeconds;
    public GameObject pointerMinutes;
    public GameObject pointerHours;
    
    //-- time speed factor
    public float clockSpeed = 1.0f;     // 1.0f = realtime, < 1.0f = slower, > 1.0f = faster

    //-- internal vars
    float msecs=0;

void Start() 
{

  
	//-- set real time
	if (realTime)
	{
		hour=System.DateTime.Now.Hour;
		minutes=System.DateTime.Now.Minute;
		seconds=System.DateTime.Now.Second;

	}
}

void Update() 
{
    //-- calculate time
    msecs += Time.deltaTime * clockSpeed;
    if(msecs >= 1.0f)
    {
        msecs -= 1.0f;
        seconds++;
        if(seconds >= 60)
        {
            seconds = 0;
            minutes++;
            if(minutes > 60)
            {
                minutes = 0;
                hour++;
                if(hour >= 24)
                    hour = 0;
                
            }
        }
    }
   
   
        
   
       if(hour>=12) {
            canvas.enabled = true;
            //paused=true;
            Time.timeScale=0;
                        
       }

   
 

    //-- calculate pointer angles
    float rotationSeconds = (360.0f / 60.0f)  * seconds;
    float rotationMinutes = (360.0f / 60.0f)  * minutes;
    float rotationHours   = ((360.0f / 12.0f) * hour) + ((360.0f / (60.0f * 12.0f)) * minutes);

    //-- draw pointers
    pointerSeconds.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationSeconds);
    pointerMinutes.transform.localEulerAngles = new Vector3(0.0f, 0.0f, rotationMinutes);
    pointerHours.transform.localEulerAngles   = new Vector3(0.0f, 0.0f, rotationHours);
    
    
    
}
}
