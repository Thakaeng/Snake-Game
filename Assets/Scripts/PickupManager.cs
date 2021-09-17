using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

// This pickup manager is for the normal game of snake
// For the rhythm pickup manager, see NotesManager.cs
public class PickupManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> pickups;
    
    [SerializeField] private AnimationCurve pickupSpawnRates;
    
    [Header("Events")]
    [SerializeField] private UnityEvent pickedUpScoreIncrease;
    [SerializeField] private UnityEvent pickedUpSpeedUp;
    [SerializeField] private UnityEvent pickedUpSpeedDown;
    

    public void ObjectPickedUp(PickupTypes input)
    {
        switch (input)
        {
            case PickupTypes.Invalid:
                Debug.Log("Invalid spawn location");
                SpawnNewPickup();
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

    public void SpawnNewPickup()
    {
        Vector3 newPosition = new Vector3(Random.Range(0, Playfield.Width), 0, Random.Range(0, Playfield.Height));

        float randomPickup = pickupSpawnRates.Evaluate(Random.value);
        
        GameObject newPickup = Instantiate(
            pickups[(int)randomPickup], 
            newPosition, 
            pickups[(int)randomPickup].transform.rotation);
        
        newPickup.transform.parent = gameObject.transform;
    }
}
