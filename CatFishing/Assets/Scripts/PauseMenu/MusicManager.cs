using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public GameObject muteButton;
    public GameObject unmuteButton;

    public void Start(){
        if(AudioListener.volume == 0) {
            unmuteButton.SetActive(false);
            muteButton.SetActive(true);
        } else {
            muteButton.SetActive(false);
            unmuteButton.SetActive(true);
        }
    }

    public void ToggleMute() {
        if(AudioListener.volume == 0) {
            muteButton.SetActive(false);
            unmuteButton.SetActive(true);
            AudioListener.volume = 1;
        } else {
            unmuteButton.SetActive(false);
            muteButton.SetActive(true);
            AudioListener.volume = 0;
        }
    }

}
