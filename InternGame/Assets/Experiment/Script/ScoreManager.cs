using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    public float scoreToReach;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameOverPanel.SetActive(false);
        scoreText.text = "" + score;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore()
    {
        Debug.Log("kena");
        score += 1;
        scoreText.text = "" + score;

        if(score >= scoreToReach)
        {
            gameOverPanel.SetActive(true);

        }

    }
}
