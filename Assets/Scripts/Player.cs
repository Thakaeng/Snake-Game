using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

class Player : MonoBehaviour
{
    private const int StartingBodyPieces = 2;

    public Transform head;
    [SerializeField] private GameObject bodyPiecePrefab;
    public List<BodyPiece> bodyPieces;

    [HideInInspector] public bool isAlive = false;

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
        var newBodyPiece = Instantiate(bodyPiecePrefab, bodyPieces.Last().Position, Quaternion.identity);
        newBodyPiece.transform.parent = gameObject.transform;
        bodyPieces.Add(newBodyPiece.GetComponent<BodyPiece>());
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Arena")) isAlive = false;
    }
}
