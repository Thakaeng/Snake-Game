using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class PickupManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _pickups;
    
    [SerializeField] private AnimationCurve pickupSpawnRates;
    
    [Header("Events")]
    [SerializeField] private UnityEvent pickedUpScoreIncrease;
    [SerializeField] private UnityEvent pickedUpSpeedUp;
    [SerializeField] private UnityEvent pickedUpSpeedDown;
    

    public void ObjectPickedUp(PickupTypes input)
    {
        switch (input)
        {
            case PickupTypes.Invalid: Debug.Log("Invalid spawn location"); SpawnNewPickup(); break;
            case PickupTypes.Apple: pickedUpScoreIncrease.Invoke(); break;
            case PickupTypes.SpeedUp: pickedUpSpeedUp.Invoke(); break;
            case PickupTypes.SpeedDown: pickedUpSpeedDown.Invoke(); break;
        }
    }

    public void SpawnNewPickup()
    {
        Vector3 newPosition = new Vector3(Random.Range(0, Playfield.width), 0, Random.Range(0, Playfield.height));

        float randomPickup = pickupSpawnRates.Evaluate(Random.value);
        GameObject newPickup = Instantiate(
            _pickups[(int)randomPickup], 
            newPosition, 
            _pickups[(int)randomPickup].transform.rotation);
        newPickup.transform.parent = gameObject.transform;
    }

    public void SpawnSpecificPickup(PickupTypes pType, Vector3Int coordinate)
    {
        Instantiate(_pickups[(int)pType], coordinate, _pickups[(int)pType].transform.rotation);
    }
    
}
