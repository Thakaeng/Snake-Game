using UnityEngine;

public class Song : MonoBehaviour
{
    public SongProperties input;
    
    public string Name;
    public int NotesCount;
    public Note[] NotesArray;
    
    private Note EndOfSong;
    private int _step = 0;

    private void Start()
    {
        Name = input.Name;
        NotesCount = input.NotesCount;

        for (int i = 0; i < NotesCount; i++)
        {
            NotesArray[i].Coordinates = input.Coords[i];
            NotesArray[i].Type = input.Types[i];
        }
        
        EndOfSong.Coordinates = Vector3.zero;
        EndOfSong.Type = PickupTypes.Invalid;
    }
    
    public Note GetNextNote()
    {
        return _step < NotesCount ?  NotesArray[_step++] : EndOfSong;
    }
}
