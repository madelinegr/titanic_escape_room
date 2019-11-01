using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Canvas canvas;
    public bool paused=false;
    public Text textGameOver; 
    public Text textGODescription; 
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        canvas.enabled=false;
        //color =textGameOver.color;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) && !paused) {
            canvas.enabled = true;
            paused=true;
            Time.timeScale=0;
            /*Debug.Log("play-to-pause");
            Debug.Log(paused);*/
       }else if(Input.GetKeyDown(KeyCode.Space) && paused) {
            canvas.enabled = false;
            paused=false;
            Time.timeScale=1;
            /*Debug.Log("pause-to-play");
            Debug.Log(paused);*/
        }
    }

   
    
    public void disableCanvas(){
        canvas.enabled=false;
        Time.timeScale=1;
        paused=false;
    }

    
}
