using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// This notes manager is for the rhythm game mode
// For the normal game of snake, see PickupManager.cs
public class NotesManager : MonoBehaviour
{
    public Song song;

    private Note _currentNote;
    
    
    [SerializeField] private List<GameObject> pickups;

    [Header("Events")]
    [SerializeField] private UnityEvent endOfSong;
    [SerializeField] private UnityEvent pickedUpScoreIncrease;
    [SerializeField] private UnityEvent pickedUpSpeedUp;
    [SerializeField] private UnityEvent pickedUpSpeedDown;


    private void Start()
    {
        Debug.Log("Playing: " + song.Name);
        
        // spawn the first two notes so that the game is always two notes ahead of the player,
        // making it easier for the player to plan out how to move
        SpawnSpecificPickup();
        SpawnSpecificPickup();
    }


    public void ObjectPickedUp(PickupTypes input)
    {
        switch (input)
        {
            case PickupTypes.Invalid:
                endOfSong.Invoke();
                break;
            case PickupTypes.Apple:
                pickedUpScoreIncrease.Invoke();
                break;
            case PickupTypes.SpeedUp:
                pickedUpSpeedUp.Invoke();
                break;
            case PickupTypes.SpeedDown:
                pickedUpSpeedDown.Invoke();
                break;
        }
    }

    public void SpawnSpecificPickup()
    {
        _currentNote = song.GetNextNote();
        if (_currentNote.Type == PickupTypes.Invalid) return;
        
        GameObject newNote = Instantiate(
            pickups[(int)_currentNote.Type], 
            _currentNote.Coordinates, 
            pickups[(int)_currentNote.Type].transform.rotation);
        newNote.transform.parent = transform;
    }
}