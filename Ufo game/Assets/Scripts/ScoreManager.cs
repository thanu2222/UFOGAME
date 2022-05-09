using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    // This variable will be to displat store  player's score
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI PanelScoreText;
    // This variable will be for the the player's score to be stored
    private float score;
    
    // Update is called once per frame
    void Update()
    {
        // This to check if the player is still alive
        if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            // Adding a value of 1 every second the player is still alive
            score += 1 * Time.deltaTime;
            // This is so that there is no decimal values in the score 
            scoreText.text = ((int)score).ToString();
            PanelScoreText.text = ((int)score).ToString();

        } 
    }
}
