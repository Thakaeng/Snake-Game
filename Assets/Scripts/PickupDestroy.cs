using UnityEngine;

public class PickupDestroy : MonoBehaviour
{
    private NotesManager _notesManager;
    public PickupTypes type;
    
    private void Start()
    {
        _notesManager = GetComponentInParent<NotesManager>();
        if(ReferenceEquals(_notesManager, null)) Debug.LogWarning("please dear god why wont you work its 3am");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SnakeBody")) _notesManager.ObjectPickedUp(PickupTypes.Invalid);
        else if (other.gameObject.CompareTag("SnakeHead")) _notesManager.ObjectPickedUp(type);
        Destroy(gameObject);
    }
}
