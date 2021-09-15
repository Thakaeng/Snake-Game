using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private int score;

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
