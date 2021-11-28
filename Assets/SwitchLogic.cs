using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLogic : MonoBehaviour
{
    public GameObject light;
    public void onoffLogic()
    {
        bool turnOn = true;
        if (light.activeSelf)
            turnOn = false;
        light.SetActive(turnOn);
    }
}
