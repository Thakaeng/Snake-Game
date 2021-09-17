using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] private GameObject pauseScreen;
    
    public void EnablePauseScreen()
    {
        switch (pauseScreen.activeSelf)
        {
            case true:
                pauseScreen.SetActive(false);
                break;
            case false:
                pauseScreen.SetActive(true);
                break;
        }
    }
}
