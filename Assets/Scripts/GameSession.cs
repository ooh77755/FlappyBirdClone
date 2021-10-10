using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    int pointsPerPipe = 1;
    int currentScore = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = currentScore.ToString();
        InvokeRepeating("AddToScore", 1, 1);
    }

    public void AddToScore()
    {
        currentScore += pointsPerPipe;
        scoreText.text = currentScore.ToString();
    }
}
