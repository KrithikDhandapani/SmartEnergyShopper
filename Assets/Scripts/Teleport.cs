using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
   


    private void OnTriggerEnter(Collider other)
    {
        if (this.tag == "TeleportUp")
        {
            other.transform.position = new Vector3(5, 8, -7);
        }

      
    }
}
