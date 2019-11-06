using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoorKey : MonoBehaviour
{
   // Start is called before the first frame update
   public string curPassword = "1234";
   public string input;
   public string tempInput;
   public bool onTrigger;
   public bool doorOpened;
   public bool keypad;
   public bool openDoor=false;
   public Text TemporalInput;
   public Canvas canvas;
   

   /*private void Update() {
       OnGUI();
   }*/
   void OnTriggerStay(Collider other)
   {    
        onTrigger = true;            
   }
   void OnTriggerExit(Collider other)
   {
        onTrigger = false;
        tempInput = "";
        keypad=false;           
   }

   private void Update() {
       if(curPassword==input.ToString()){
           openDoor=true;
       }
       
       TemporalInput.text=tempInput;
       
       
       
       /*if(onTrigger )
       {
           GUI.Box(new Rect(0, 0, 200, 25), "Press E to open keypad");
           if (Input.GetKeyDown(KeyCode.E))
           {
               keypad = true;
               onTrigger = false;
           }
       }*/


   }
 
   /*void OnGUI()
   {
       if(onTrigger )
       {
           GUI.Box(new Rect(0, 0, 200, 25), "Press E to open keypad");
           if (Input.GetKeyDown(KeyCode.E))
           {
               keypad = true;
               onTrigger = false;
           }
       }
       if (keypad)
       {
           GUI.Box(new Rect(0, 0, 320, 400), "");
           GUI.Box(new Rect(5, 5, 310, 25), tempInput);
           if (GUI.Button(new Rect(5, 35, 100, 100), "1"))
           {
               tempInput = "1";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
           {
               tempInput = "2";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
           {
               tempInput = "3";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
           {
               tempInput = "4";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
           {
               tempInput = "5";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
           {
               tempInput = "6";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
           {
               tempInput = "7";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
           {
               tempInput = "8";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
           {
               tempInput = "9";
               input = input + tempInput;
           }
           if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
           {
               tempInput = "0";
               input = input + tempInput;
           }
       }
   }*/

    public void Button1(){
        tempInput = "1";
        input = input + tempInput;
    }

    public void Button2(){
        tempInput = "2";
        input = input + tempInput;
    }

    public void Button3(){
        tempInput = "3";
        input = input + tempInput;
    }

    public void Button4(){
        tempInput = "4";
        input = input + tempInput;
    }

    public void Button5(){
        tempInput = "5";
        input = input + tempInput;
    }

    public void Button6(){
        tempInput = "6";
        input = input + tempInput;
    }

    public void Button7(){
        tempInput = "7";
        input = input + tempInput;
    }

    public void Button8(){
        tempInput = "8";
        input = input + tempInput;
    }

    public void Button9(){
        tempInput = "9";
        input = input + tempInput;
    }

    public void Button0(){
        tempInput = "0";
        input = input + tempInput;
    }
}
/*
   void OnTriggerEnter(Collider other)
   {
       inTrigger = true;
   }
   // Update is called once per frame
   void OnTriggerExit(Collider other)
   {
       inTrigger = false;
   }
   void Update()
   {
       if (inTrigger)
       {
           if (Input.GetKeyDown(KeyCode.E))
           {
               newDoorScript.doorKey = true;
               Destroy(this.gameObject);
           }
       }
   }
   void OnGUI(){
       if (inTrigger)
       {
           GUI.Box(new Rect(0,60,200,25), "Press E to take key");
       }
   }
}
*/