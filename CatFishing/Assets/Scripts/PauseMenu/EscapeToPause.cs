using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToPause : MonoBehaviour {

[SerializeField] GameObject pauseMenu;
[SerializeField] GameObject controls;

    public void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume() {
        controls.SetActive(false);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(Time.timeScale == 1f) {
                Pause();
            }
            else {
                Resume();
            }
        }
    }
}