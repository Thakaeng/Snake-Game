using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class PickupManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> _pickups;
    [SerializeField] private UnityEvent scoreIncreasePickup;
    public Score score;

    private void Awake()
    {
        score = GameObject.FindWithTag("MainCamera").GetComponent<Score>();
    }

    public void ObjectPickedUp(PickupTypes input)
    {
        switch (input)
        {
            case PickupTypes.Invalid: Debug.Log("Invalid spawn location"); SpawnNewPickup(); break;
            case PickupTypes.Apple: scoreIncreasePickup.Invoke(); break;
        }
    }
    
    public void SpawnNewPickup()
    {
        Vector3 newPosition = new Vector3(Random.Range(0, Playfield.width), 0, Random.Range(0, Playfield.height));
        GameObject newPickup = Instantiate(_pickups[0],newPosition, Quaternion.identity);
        newPickup.transform.parent = gameObject.transform;
    }
}
