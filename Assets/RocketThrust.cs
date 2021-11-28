using System;
using UnityEngine;
using System.Collections;
using UnityEngine.Assertions;
using UnityEngine.XR;
using CommonUsages = UnityEngine.XR.CommonUsages;
using InputDevice = UnityEngine.XR.InputDevice;


public class RocketThrust : MonoBehaviour 
{ 
    public GameObject hand;
    public GameObject rig;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        Vector3 thrustOrient = hand.transform.forward;
        rig.transform.position += thrustOrient * .5f * Time.deltaTime;
        
    }
}
