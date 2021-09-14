using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class BodyPiece : MonoBehaviour
{
    private Vector3 position;
    
    public Vector3 Position
    {
        get => position;
        set => position = value;
    }

    public void MovePiece(Vector3 targetPos)
    {
        transform.position = targetPos;
    }
}
