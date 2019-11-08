using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Valve.VR.Extras;
[RequireComponent(typeof(SteamVR_LaserPointer))]
public class VRUIInput : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    public bool onTrigger;

    //private SteamVR_LaserPointer laserPointer;
    //private SteamVR_TrackedController trackedController;
    
 
    void Awake()
    {
        // laserPointer.PointerIn += PointerInside;
        // laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }
    private void OnEnable()
    {
        laserPointer = GetComponent<SteamVR_LaserPointer>();
        laserPointer.PointerIn -= HandlePointerIn;
        laserPointer.PointerIn += HandlePointerIn;
        laserPointer.PointerOut -= HandlePointerOut;
        laserPointer.PointerOut += HandlePointerOut;

        //trackedController = GetComponent<SteamVR_TrackedController>();
        // if (trackedController == null)
        // {
        //     //trackedController = GetComponentInParent<SteamVR_TrackedController>();
        // }
        // trackedController.TriggerClicked -= HandleTriggerClicked;
        // trackedController.TriggerClicked += HandleTriggerClicked;
    }
    public void PointerClick(object sender, PointerEventArgs e)
    {
        
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            ExecuteEvents.Execute(EventSystem.current.currentSelectedGameObject, new PointerEventData(EventSystem.current), ExecuteEvents.submitHandler);
            //var button = e.target.GetComponent<Button>();
            //button.onClick.Invoke();
        }
    }

    // private void HandleTriggerClicked(object sender, ClickedEventArgs e)
    // {
    //     if (EventSystem.current.currentSelectedGameObject != null)
    //     {
    //         ExecuteEvents.Execute(EventSystem.current.currentSelectedGameObject, new PointerEventData(EventSystem.current), ExecuteEvents.submitHandler);
    //     }
    // }

    private void HandlePointerIn(object sender, PointerEventArgs e)
    {
        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            button.Select();
            Debug.Log("HandlePointerIn", e.target.gameObject);
        }
    }

    private void HandlePointerOut(object sender, PointerEventArgs e)
    {
        
        var button = e.target.GetComponent<Button>();
        if (button != null)
        {
            EventSystem.current.SetSelectedGameObject(null);
            Debug.Log("HandlePointerOut", e.target.gameObject);
        }
    }
}
