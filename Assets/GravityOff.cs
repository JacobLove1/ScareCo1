using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOff : MonoBehaviour
{
    // Start is called before the first frame update
    public void GravityO()
    {
        Physics.gravity = new Vector3(0, 0, 0);
    }

}