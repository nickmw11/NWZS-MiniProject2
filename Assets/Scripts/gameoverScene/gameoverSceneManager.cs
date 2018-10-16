using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameoverSceneManager : MonoBehaviour {

    
    public Text highScoreDisplay;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScoreDisplay.text = "High Score: " + PlayerPrefs.GetInt(Constants.S.playerPrefHighScoreKey);
        if (Input.GetKey(KeyCode.Space))
            UnityEngine.SceneManagement.SceneManager.LoadScene("main");
    }
}
