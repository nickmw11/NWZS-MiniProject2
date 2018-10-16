using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainSceneManager : MonoBehaviour {

    public float timer;
    public Text Times;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Times.text = "Time: " + Mathf.Floor(timer).ToString();

        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log((int)Mathf.Floor(timer) + " " + PlayerPrefs.GetInt(Constants.S.playerPrefHighScoreKey));
            Debug.Log(Constants.S.playerPrefHighScoreKey);
            if ((int)Mathf.Floor(timer) > PlayerPrefs.GetInt(Constants.S.playerPrefHighScoreKey))
            {
                PlayerPrefs.SetInt(Constants.S.playerPrefHighScoreKey, (int)Mathf.Floor(timer));
            }
            Debug.Log(PlayerPrefs.GetInt(Constants.S.playerPrefHighScoreKey));
            UnityEngine.SceneManagement.SceneManager.LoadScene("Gameover");
        }
    }
}
