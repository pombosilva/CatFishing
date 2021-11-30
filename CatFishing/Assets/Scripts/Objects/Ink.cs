using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ink : MonoBehaviour
{
    SpriteRenderer rend;
    void Start() {
        rend = GetComponent<SpriteRenderer>();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut() {
        yield return new WaitForSeconds(3);
        for (float f = 1f; f > 0; f -= 0.01f){
            Color c = rend.color;
            c.a = f;
            rend.color = c;
            yield return new WaitForSeconds(0.01f);
        }
        Destroy(this);
    }
}
