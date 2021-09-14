using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDestroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
