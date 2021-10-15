using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartGen : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Spawnpoint;
    public GameObject Prefab;
    public bool pressed;

    void Start()
    {
        pressed = false;
        InvokeRepeating("PressState", 2f, 1f);
    }
    void PressState() {
        pressed = false;
    }
    void OnTriggerEnter()
    {
        if (pressed == false)
        {
            GameObject instance = GameObject.Instantiate(Prefab) ;
            pressed = true;
        }

    }
}
