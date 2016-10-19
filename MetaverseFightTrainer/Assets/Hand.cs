﻿using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {
    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    public bool gripButtonDown = false;
    public bool gripButtonUp = false;
    public bool gripButtonPressed = false;

    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    public bool triggerButtonDown = false;
    public bool triggerButtonUp = false;
    public bool triggerButtonPressed = false;

    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

	// Use this for initialization
	void Start () {
        trackedObj = GetComponent<SteamVR_TrackedObject>();

	}
	
	// Update is called once per frame
	void Update () {
        if (controller == null)
        {
            Debug.Log("Controller not init");
            return;
        }

        gripButtonDown = controller.GetPressDown(gripButton);
        gripButtonUp = controller.GetPressUp(gripButton);
        gripButtonPressed = controller.GetPress(gripButton);

        triggerButtonDown = controller.GetPressDown(triggerButton);
        triggerButtonUp = controller.GetPressUp(triggerButton);
        triggerButtonPressed = controller.GetPress(triggerButton);

        if (gripButtonDown)
        {
            Debug.Log("Grip button pressed down");
        }

        if (gripButtonPressed)
        {
            Debug.Log("Grip button is being held down");
        }

        if (gripButtonUp)
        {
            Debug.Log("Grip button released");
        }

        if (triggerButtonDown)
        {
            Debug.Log("Trigger button pressed down");
        }

        if (triggerButtonPressed)
        {
            Debug.Log("Trigger button is being held down");
        }

        if (triggerButtonDown)
        {
            Debug.Log("Trigger button released");
        }


    }
}
