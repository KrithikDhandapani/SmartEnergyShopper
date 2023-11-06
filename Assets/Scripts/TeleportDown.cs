using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportDown : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new Vector3(-8, 2, -7);
    }
}
