using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHead : MonoBehaviour
{
    private Player _player;

    private void Awake()
    {
        _player = GetComponentInParent<Player>();
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("ded");
        if (other.gameObject.CompareTag("SnakeBody")) _player.isAlive = false;
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("u ded boi");
        if (other.gameObject.CompareTag("Arena")) _player.isAlive = false;
    }
}
