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
    // Start is called before the first frame update
    void Start()
    {
        initRot= hinge;
        inity=hinge.rotation.y ;
        targy=hinge.rotation.y +90;
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            state=true;
        }     
    }


    void Update(){

        transition= Mathf.LerpAngle(inity, targy, Time.time*speed);
        initRot.Rotate(0, transition, 0);        
        transform.rotation = Quaternion.Euler(transform.rotation.x , transform.rotation.y + transition,transform.rotation.z );        
    }

   
}
