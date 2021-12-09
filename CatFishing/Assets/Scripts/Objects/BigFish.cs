using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFish : Adagio {

    public SpriteRenderer spriteRenderer;
    private int score = 2;
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
