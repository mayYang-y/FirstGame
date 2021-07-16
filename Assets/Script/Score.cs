using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    float timer;
    float maxTimer;
    int score;
    public Text scoreText;
    public Text hiScoreText;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        maxTimer = 0.1f;
        scoreText = GetComponent<Text>();
        audioSource = GetComponent<AudioSource>();
        hiScoreText.text = "HI " + PlayerPrefs.GetInt("highscore",0).ToString("00000");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTimer){
            score ++;
            scoreText.text = score.ToString("00000");
            timer = 0;
        }

        if (score > 0 && score % 100 == 0){
            audioSource.Play();
        }
    }

    public void setHiScore(){
        if (score > PlayerPrefs.GetInt("highscore",0)){
            PlayerPrefs.SetInt("highscore",score);
            hiScoreText.text = "HI " + PlayerPrefs.GetInt("highscore",0).ToString("00000");
        }
    }
}
