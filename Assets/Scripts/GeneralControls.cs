using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GeneralControls : MonoBehaviour
{

    [SerializeField] private Player player;

    [SerializeField] private UnityEvent pauseGame;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        if (Input.GetKeyDown(KeyCode.Space)) pauseGame.Invoke();
        if (Input.GetKeyDown(KeyCode.R)) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
