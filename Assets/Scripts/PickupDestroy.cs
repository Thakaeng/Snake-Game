using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SnakeHead")) /*add point to score*/;
        // Spawn new pickup
        Destroy(gameObject);
    }
}
