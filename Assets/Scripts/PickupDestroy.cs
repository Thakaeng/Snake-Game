using UnityEngine;
using UnityEngine.SceneManagement;

public class PickupDestroy : MonoBehaviour
{
    private PickupManager _pickupManager;
    private NotesManager _notesManager;
    public PickupTypes type;

    private string _currentScene;
    
    private void Start()
    {
        _currentScene = SceneManager.GetActiveScene().name;
        
        if (_currentScene == "MainGame") _pickupManager = GetComponentInParent<PickupManager>();
        else _notesManager = GetComponentInParent<NotesManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_currentScene == "MainGame")
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
