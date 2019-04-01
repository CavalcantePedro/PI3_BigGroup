using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private string nextScene;

    public void ChangeScene(string sceneName, float delay = 0){
        nextScene = sceneName;
        Invoke("SceneDelay", delay);
    }

    private void SceneDelay(){
        SceneManager.LoadScene(nextScene);
    }
}
