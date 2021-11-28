using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOn : MonoBehaviour
{
    // Start is called before the first frame update
    public void Gravity()
    {
        Physics.gravity = new Vector3(0, -1.0F, 0);
    }

}
