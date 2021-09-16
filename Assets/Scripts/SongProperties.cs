using UnityEngine;

public class SongProperties : MonoBehaviour
{
    public string Name;

    public int NotesCount;

    public PickupTypes[] Types = new PickupTypes[]
    {
        PickupTypes.Apple,
        PickupTypes.Apple,
        PickupTypes.Apple,
        PickupTypes.Apple,
        PickupTypes.Apple,
        PickupTypes.Apple,
        PickupTypes.Apple,
        PickupTypes.Apple,
        PickupTypes.Apple,
        PickupTypes.Apple
    };

    public Vector3[] Coords = new Vector3[]
    {
        new Vector3(5, 0, 5),
        new Vector3(6, 0, 5),
        new Vector3(7, 0, 5),
        new Vector3(8, 0, 5),
        new Vector3(9, 0, 5),
        new Vector3(10, 0, 5),
        new Vector3(11, 0, 5),
        new Vector3(12, 0, 5),
        new Vector3(13, 0, 5),
        new Vector3(14, 0, 5)
    };
}