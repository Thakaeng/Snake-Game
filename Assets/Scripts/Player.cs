using System.Collections.Generic;
using System.Linq;
using UnityEngine;

class Player : MonoBehaviour
{
    private const int StartingBodyPieces = 2;

    [SerializeField] private GameObject noteMarker;
    
    public Transform headTransform;
    [SerializeField] private GameObject bodyPiecePrefab;
    public List<SnakeBodyPiece> bodyPieces;

    [HideInInspector] public bool isAlive;

    private void Awake()
    {
        isAlive = false;
    }

    public void Start()
    {
        headTransform = transform.GetChild(0).transform;
        for (int i = 1; i <= StartingBodyPieces; i++)
        {
            bodyPieces.Add(transform.GetChild(i).GetComponent<SnakeBodyPiece>());
        }
    }

    public void AddBodyPiece()
    {
        var newBodyPiece = Instantiate(bodyPiecePrefab, bodyPieces.Last().Position, Quaternion.identity);
        newBodyPiece.transform.parent = gameObject.transform;
        bodyPieces.Add(newBodyPiece.GetComponent<SnakeBodyPiece>());
    }

    public void ToggleMovement()
    {
        isAlive = !isAlive;
    }

    public void PlaceNoteMarker()
    {
        Instantiate(noteMarker, headTransform.transform.position, noteMarker.transform.rotation);
    }
}
