using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupDestroy : MonoBehaviour
{
    private PickupManager _pickupManager;
    private NotesManager _notesManager;
    public PickupTypes type;

    private string _curScene;
    
    private void Start()
    {
        _curScene = SceneManager.GetActiveScene().name;
        
        if (_curScene == "MainGame") _pickupManager = GetComponentInParent<PickupManager>();
        else _notesManager = GetComponentInParent<NotesManager>();
        
        if (ReferenceEquals(_pickupManager, null)) Debug.LogWarning("please dear god why wont you work its 3am");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_curScene == "MainGame")
        {
            if (other.gameObject.CompareTag("SnakeBody")) _pickupManager.ObjectPickedUp(PickupTypes.Invalid);
            else if (other.gameObject.CompareTag("SnakeHead")) _pickupManager.ObjectPickedUp(type);
        }
        else
        {
            if (other.gameObject.CompareTag("SnakeBody")) _notesManager.ObjectPickedUp(PickupTypes.Invalid);
            else if (other.gameObject.CompareTag("SnakeHead")) _notesManager.ObjectPickedUp(type);
        }
        Destroy(gameObject);
    }
}
