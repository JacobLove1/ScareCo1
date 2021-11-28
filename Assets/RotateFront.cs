using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFront : MonoBehaviour
{
    public GameObject world;
    public GameObject player;
    // Start is called before the first frame update
    public void turn()
    {

        world.transform.RotateAround(player.transform.position, Vector3.right, 90);
    }
}