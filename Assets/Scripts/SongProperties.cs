using System;
using UnityEngine;

public class SongProperties : MonoBehaviour
{
    public string Name;

    public Vector3[] Coords;
    
    public PickupTypes[] Types;

    private void Awake()
    {
        Types = new PickupTypes[Coords.Length];
        
        for (int i = 0; i < Coords.Length; i++)
        {
            Types[i] = PickupTypes.Apple;
        }
    }
}