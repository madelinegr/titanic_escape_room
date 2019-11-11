using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class DoorKey : MonoBehaviour
{
    public SteamVR_Behaviour_Pose pose;
    public SteamVR_Action_Boolean interactWithUI = SteamVR_Input.GetBooleanAction("InteractUI");
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
   public SteamVR_Action_Boolean SphereOnOff;
   public SteamVR_Input_Sources handType;
   public GameObject Sphere;
    public event PointerEventHandler PointerClick;

   public Animator animator;

   void Awake(){
       PointerEventArgs argsClick = new PointerEventArgs();
       OnPointerClick(argsClick);
   }    
   /*private void Update() {
       OnGUI();
   }*/
   void Start()
    {
        //pose = this.GetComponent<SteamVR_Behaviour_Pose>();
    }
    public virtual void OnPointerClick(PointerEventArgs e)
        {
                Debug.Log("click in doorkey");
            if (PointerClick != null)
                PointerClick(this, e);
        }
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
       if (interactWithUI.GetStateUp(pose.inputSource))
            {
                PointerEventArgs argsClick = new PointerEventArgs();
                OnPointerClick(argsClick);
            }
        
        if (Input.GetButtonDown("htc"))
        {
            
        }
        if(curPassword==input.ToString()){
           openDoor=true;
        }
       
       TemporalInput.text=tempInput;
       if (Input.GetKeyDown(KeyCode.E)){
           animator.SetBool("Active", true);
           Debug.Log("3333333333333333333333333333");
       }
    //    if(onTrigger==false){
    //        animator.SetBool("Active", false);
    //    }
       
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
