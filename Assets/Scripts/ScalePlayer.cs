using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalePlayer : MonoBehaviour
{
   public GameObject player;
   public bool state=false;
   public float scale;
   public float speed;
   public float count=0;
   
   private bool DecreaseScale=true;


   public float FinalScale;
   private float scaleTarget;
   // Start is called before the first frame update
   void Start()
   {
        scaleTarget=scale;
   }
   // Update is called once per frame
   void Update()
   {
    //   player.transform.scale
       if(Input.GetKeyDown(KeyCode.E)){
           state=true;
           scaleTarget=scale;
           count=0;
       }


       if(state && count<=1){
           count+=0.01f;
       }

       //if(player.transform.localScale.x<scale){
       FinalScale=Mathf.Lerp(player.transform.localScale.x,scaleTarget, count*speed);
        player.transform.localScale= new Vector3(FinalScale,FinalScale,FinalScale);
        /*}else//if(player.transform.localScale.x>scaleTarget)
        {
            FinalScale=Mathf.Lerp(scaleTarget,player.transform.localScale.x , count*speed);
        player.transform.localScale= new Vector3(FinalScale,FinalScale,FinalScale);
        }*/
   }
   
    void OnTriggerEnter(Collider col){
            if(col.tag == "Player" ){
            state=true;
            //scaleTarget=scale;
            DecreaseScale=false;
            Debug.Log("77777777777777777777777777777777777777777777777777777777777777777");
            count=0;
            
            
            // BackColliders.SetActive(true);
            // NextColliders.SetActive(true);
            // ThisColliders.SetActive(false);
        } 
   }

 void OnTriggerExit(Collider col){
        
        
        state=false;
        count=0;
            // BackColliders.SetActive(true);
            // NextColliders.SetActive(true);
            // ThisColliders.SetActive(false);
         
   }

   public void NormalScale(){
       Debug.Log("Bottle");
       /* state=true;
        scaleTarget=1;*/
        //player.transform.localScale= new Vector3(1,1,1);
        //count=0;
   }

   void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Bottle" && DecreaseScale){
            state=true;
            scaleTarget=2;
            count=0;
            player.transform.localScale= new Vector3(1,1,1);  
            Debug.Log("funca");
            DecreaseScale=false;
        }else{
            Debug.Log("no Funca");
        }
    }
}
