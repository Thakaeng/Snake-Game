using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int cooldownTimeInMS;

    private Player _player;
    
    private Vector3 _dir = Vector3.right;
    private float _movementCooldown = 0;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) _player.isAlive = !_player.isAlive;
        
        if (!_player.isAlive) return;
        
        if (Input.GetKeyDown(KeyCode.W)) _dir = Vector3.forward;
        else if (Input.GetKeyDown(KeyCode.A)) _dir = Vector3.left;
        else if (Input.GetKeyDown(KeyCode.S)) _dir = Vector3.back;
        else if (Input.GetKeyDown(KeyCode.D)) _dir = Vector3.right;

        if (_movementCooldown >= Time.time) return;
        
        _movementCooldown = Time.time + (0.001f * cooldownTimeInMS);
        MoveBodyParts();
        _player.head.transform.position += _dir;
        
    }

    private void MoveBodyParts()
    {
        
        for (int i = _player.bodyPieces.Count - 1; i > 0; i--)
        {
            _player.bodyPieces[i].MovePiece(_player.bodyPieces[i-1].Position);
        }
        _player.bodyPieces[0].MovePiece(_player.head.transform.position);
    }
    
}
