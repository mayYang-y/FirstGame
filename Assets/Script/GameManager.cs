using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverPanel;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale= 1;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver(){
        Time.timeScale= 0;
        gameOverPanel.SetActive(true);
        audioSource.Play();
    }

    public void ReStart(){
        SceneManager.LoadScene("SampleScene");
    }
}
