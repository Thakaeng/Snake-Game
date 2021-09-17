using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text multiplierText;
    [SerializeField] private float score;
    [SerializeField] private float scoreMultiplier = 1f;

    private int baseScoreIncrease = 1;
    
    public void IncreaseScore()
    {
        if(score == 0) { score++; return; }
        
        score += baseScoreIncrease * scoreMultiplier;
        scoreText.text = score.ToString("F0");
    }

    public void IncreaseMultiplier(bool increase)
    {
        switch (increase)
        {
            case true: scoreMultiplier += 0.1f; break;
            case false: scoreMultiplier -= 0.1f;  break;
        }

        Mathf.Clamp(scoreMultiplier - 0.1f, 0f, 20f);
        multiplierText.text = "x" + scoreMultiplier.ToString("F1");
    }
}
