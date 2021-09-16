using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class SnakeBodyPiece : MonoBehaviour
{
    private Vector3 position;
    
    public Vector3 Position
    {
        get => transform.position;
    }

    public void MovePiece(Vector3 targetPos)
    {
        transform.position = targetPos;
    }
}
