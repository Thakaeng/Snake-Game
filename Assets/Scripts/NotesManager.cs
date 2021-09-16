using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NotesManager : MonoBehaviour
{
    public Song song;

    private Note currentNote;
    
    
    [SerializeField] private List<GameObject> pickups;

    [Header("Events")]
    [SerializeField] private UnityEvent endOfSong;
    [SerializeField] private UnityEvent pickedUpScoreIncrease;
    [SerializeField] private UnityEvent pickedUpSpeedUp;
    [SerializeField] private UnityEvent pickedUpSpeedDown;


    private void Start()
    {
        Debug.Log(song.Name);
        SpawnSpecificPickup();
    }


    public void ObjectPickedUp(PickupTypes input)
    {
        switch (input)
        {
            case PickupTypes.Invalid: endOfSong.Invoke(); break;
            case PickupTypes.Apple: pickedUpScoreIncrease.Invoke(); break;
            case PickupTypes.SpeedUp: pickedUpSpeedUp.Invoke(); break;
            case PickupTypes.SpeedDown: pickedUpSpeedDown.Invoke(); break;
        }
    }

    public void SpawnSpecificPickup()
    {
        currentNote = song.GetNextNote();
        Instantiate(
            pickups[(int)currentNote.Type], 
            currentNote.Coordinates, 
            pickups[(int)currentNote.Type].transform.rotation);
    }
}