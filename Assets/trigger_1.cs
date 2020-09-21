using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_1 : MonoBehaviour
{
    public Camera Camera_1;
    public Camera Camera_2;

    void OnTriggerEnter2D(Collider2D other)
    {
        Camera_1.enabled = false;
        Camera_2.enabled = true;
    }
}
