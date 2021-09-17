using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GeneralControls : MonoBehaviour
{
    [SerializeField] private UnityEvent pauseGame;
    [SerializeField] private UnityEvent placeNoteMarker;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        if (Input.GetKeyDown(KeyCode.Space)) pauseGame.Invoke();
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        if (Input.GetKeyDown(KeyCode.Alpha1)) SceneManager.LoadScene("MainGame");
        // else if (Input.GetKeyDown(KeyCode.Alpha2)) SceneManager.LoadScene("RhythmTest");
        
        if (Input.GetKeyDown(KeyCode.Return)) placeNoteMarker.Invoke();
    }
}
