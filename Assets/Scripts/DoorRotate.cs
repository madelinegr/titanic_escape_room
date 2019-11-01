using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotate : MonoBehaviour
{
    public Transform hinge;    
    public Transform initRot;
    public float speed=0.1f;
    private float transition;
    private bool state=false;
    private float targy;
    private float inity;
    public DoorKey Rotateclass;
    public float actualTime;
    public float count=0;
    public bool WayRotation=false;
    // Start is called before the first frame update
    void Start()
    {
        
        initRot= hinge;
        inity=hinge.rotation.y ;
        if(WayRotation){
            targy=hinge.rotation.y +90;
        }else{
            targy=hinge.rotation.y -90;
        }
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            state=true;
        }     
    }


    void Update(){
        if(Rotateclass.openDoor){
            count+=0.01f;
            actualTime=Time.time;
            transition= Mathf.LerpAngle(inity, targy, (count)*speed);
            initRot.Rotate(0, transition, 0);        
            transform.rotation = Quaternion.Euler(transform.rotation.x , transform.rotation.y + transition,transform.rotation.z );        
        }
        
    }

   
}
