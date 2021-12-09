using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallFish : Adagio {

    public SpriteRenderer spriteRenderer;
    private int score = 1;
    public override void interact() {
        if(!isCaught) {
            isCaught = true;
            ScoreController.Increment(score);
            AudioSource audioSource = GetComponent<AudioSource>();
            spriteRenderer.enabled = false;
            audioSource.Play();
            Destroy(this.gameObject, audioSource.clip.length);
        }
    }
}
