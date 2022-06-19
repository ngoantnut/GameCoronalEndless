using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public float score;
    public Text h_score;

    // Start is called before the first frame update
    private void Start()
    {
       // h_score = PlayerPrefs.GetFloat("High Score",score).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
            
           // File.WriteAllLinesAsync("Score.txt", score);
        }
        PlayerPrefs.SetFloat("HighScore",score);
        PlayerPrefs.Save();
        //float high = PlayerPrefs.GetFloat("HighScore");
        //h_score.text = high.ToString(); 
    }


}


