using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour {
    public void QuitGame(){
        Application.Quit();
    }

    public void ResetScene(string sceneManager){
        SceneManager.LoadScene(sceneManager);
    }
}
