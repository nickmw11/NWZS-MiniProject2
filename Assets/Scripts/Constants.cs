using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour {

    public string playerPrefHighScoreKey = "playerHighScore";
    static public Constants S;
    public int highScore;

    void Awake()
    {
        S = this;

        //if (!PlayerPrefs.HasKey(playerPrefHighScoreKey))
        //{
        //    highScore = PlayerPrefs.GetInt(playerPrefHighScoreKey);
        //    Debug.Log("Reading Player Prefs");
        //}
        //else
        //{
        //    Debug.Log("setting player prefs for first time");
        //    PlayerPrefs.SetInt(playerPrefHighScoreKey, highScore);
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Start()
    {
        if (PlayerPrefs.HasKey(playerPrefHighScoreKey))
        {
            highScore = PlayerPrefs.GetInt(playerPrefHighScoreKey);
            Debug.Log("Reading Player Prefs");
        }
        else
        {
            Debug.Log("setting player prefs for first time");
            PlayerPrefs.SetInt(playerPrefHighScoreKey, highScore);
        }
    }
}
