using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    public GameObject stuff;
    // Start is called before the first frame update
    public void shrink()
    {
        stuff.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
    }
}
