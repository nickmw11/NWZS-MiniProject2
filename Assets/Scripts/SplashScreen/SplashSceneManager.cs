using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashSceneManager : MonoBehaviour {

    public float time;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
        //if (time > 1)
        //    UnityEngine.SceneManagement.SceneManager.LoadScene("main");
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(3f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("main");
    }
}
