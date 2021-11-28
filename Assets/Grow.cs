using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public GameObject stuff;
    // Start is called before the first frame update
    public void grow()
    {
        stuff.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}