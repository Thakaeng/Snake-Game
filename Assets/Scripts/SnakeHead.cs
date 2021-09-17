using UnityEngine;

public class SnakeHead : MonoBehaviour
{
    private Player _player;

    private void Awake()
    {
        _player = GetComponentInParent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SnakeBody"))
        {
            _player.isAlive = false;
            Debug.Log("self destruction lol");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (other.gameObject.CompareTag("Arena"))
        {
            _player.isAlive = false;
            Debug.Log("you cannot run away from you fate");
        }
    }
}
