using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float cooldownTimeInSeconds;

    private Player player;
    
    private Vector3 dir;
    private float movementCooldown = 0;


    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.W)) { dir = Vector3.forward; }
        else if (Input.GetKeyDown(KeyCode.A)) { dir = Vector3.left; }
        else if (Input.GetKeyDown(KeyCode.S)) { dir = Vector3.back; }
        else if (Input.GetKeyDown(KeyCode.D)) { dir = Vector3.right; }


        if (movementCooldown <= Time.time)
        {
            movementCooldown = Time.time + cooldownTimeInSeconds;
            transform.position += dir;
        }
    }

    private void MoveBodyParts()
    {
        
    }
    
}
