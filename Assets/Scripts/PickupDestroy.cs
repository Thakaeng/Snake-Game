using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickupDestroy : MonoBehaviour
{
    private PickupManager pm;
    public PickupTypes type;
    
    private void Start()
    {
        pm = GetComponentInParent<PickupManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SnakeBody")) pm.ObjectPickedUp(PickupTypes.Invalid);
        else if (other.gameObject.CompareTag("SnakeHead")) pm.ObjectPickedUp(type);
        Destroy(gameObject);
    }
}
