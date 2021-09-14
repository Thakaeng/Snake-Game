using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Player : MonoBehaviour
{
    private const int StartingBodyPieces = 2;

    public Transform head;
    public List<BodyPiece> bodyPieces;

    public void Start()
    {
        head = transform.GetChild(0);
        for (int i = 1; i <= StartingBodyPieces; i++)
        {
            bodyPieces.Add(transform.GetChild(i).GetComponent<BodyPiece>());
        }
    }

    public void AddBodyPiece()
    {
        
    }
}
