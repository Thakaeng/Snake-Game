using UnityEngine;

public class SongProperties : MonoBehaviour
{
    public string Name;

    public Vector3[] coords;
    
    public PickupTypes[] types;

    private void Awake()
    {
        types = new PickupTypes[coords.Length];
        
        for (int i = 0; i < coords.Length; i++)
        {
            types[i] = PickupTypes.Apple;
        }
    }
}