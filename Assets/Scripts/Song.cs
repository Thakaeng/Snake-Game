using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{
    public SongProperties input;
    
    public string Name;
    public int notesCount;
    private List<Note> _notesList = new List<Note>();

    private Note EndOfSong = new Note();
    private Note _newNote;
    private int _step = 0;

    private void Start()
    {
        Name = input.Name;
        notesCount = input.coords.Length;

        for (int i = 0; i < notesCount; i++)
        {
            _newNote = new Note();
            _newNote.Coordinates = input.coords[i];
            _newNote.Type = input.types[i];
            _notesList.Add(_newNote);
        }
        
        EndOfSong.Coordinates = Vector3.zero;
        EndOfSong.Type = PickupTypes.Invalid;
    }
    
    public Note GetNextNote()
    {
        return _step < notesCount ?  _notesList[_step++] : EndOfSong;
    }
}
