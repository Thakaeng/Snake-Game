using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    public SongProperties input;
    
    public string Name;
    public int NotesCount;
    private List<Note> _notesList = new List<Note>();

    private Note EndOfSong = new Note();
    private Note _newNote;
    private int _step = 0;

    private void Start()
    {
        Name = input.Name;
        NotesCount = input.Coords.Length;

        for (int i = 0; i < NotesCount; i++)
        {
            _newNote = new Note();
            _newNote.Coordinates = input.Coords[i];
            _newNote.Type = input.Types[i];
            _notesList.Add(_newNote);
        }
        
        EndOfSong.Coordinates = Vector3.zero;
        EndOfSong.Type = PickupTypes.Invalid;
    }
    
    public Note GetNextNote()
    {
        return _step < NotesCount ?  _notesList[_step++] : EndOfSong;
    }
}
