using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

[SerializeField] GameObject pauseMenu;
[SerializeField] GameObject controls;

    public void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GoToScene(int sceneID) {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void Defs(int sceneID) {
        if(sceneID == 0)
            pauseMenu.SetActive(false);
        controls.SetActive(true);
    }

    public void ResumeDefs(int sceneID) {
        if(sceneID == 0)
            pauseMenu.SetActive(true);
        controls.SetActive(false);
    }
}
