using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour {

    private static int MAXLIVES = 3;
    public GameObject[] worms = new GameObject[MAXLIVES];
    private int index;
    private static int lives;

    public void Start() {
        lives = MAXLIVES;
        index = MAXLIVES - 1;
    }
    public void Update(){
        if(lives < MAXLIVES) {
            if(index == lives){
                Destroy(worms[index--]);
                if(lives == 0)
                    SceneManager.LoadScene(2);
            }
        }
    }
    public static void LoseLife(){
        lives--;
    }
}
