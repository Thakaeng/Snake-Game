using UnityEngine;

class SnakeBodyPiece : MonoBehaviour
{
    public Vector3 Position => transform.position;

    public void MovePiece(Vector3 targetPos)
    {
        transform.position = targetPos;
    }
}
