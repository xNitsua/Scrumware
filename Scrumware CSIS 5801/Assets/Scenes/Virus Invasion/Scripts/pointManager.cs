using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
   public void UpdateScore(int points)
   {
        score += points;
        scoreText.text = "Score: " + score;
   }
}
