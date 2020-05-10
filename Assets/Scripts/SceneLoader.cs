using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene() {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Current scene: " + currentSceneIndex);
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene() {
        SceneManager.LoadScene(0);
    }

    public void EndGame() {
        Application.Quit();
    }
}
