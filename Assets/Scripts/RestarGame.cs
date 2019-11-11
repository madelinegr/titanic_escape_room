using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestarGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
       {
          Application.Quit();
       }
    }
    public void ReloadScene(){
        SceneManager.LoadSceneAsync("titanicroom_scaled");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
