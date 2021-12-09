using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garbage : Adagio {

    public SpriteRenderer spriteRenderer;
    public override void interact() {
        if(!isCaught) {
            isCaught = true;
            Lives.LoseLife();
            AudioSource audioSource = GetComponent<AudioSource>();
            spriteRenderer.enabled = false;
            audioSource.Play();
            Destroy(this.gameObject, audioSource.clip.length);
        }
    }
}