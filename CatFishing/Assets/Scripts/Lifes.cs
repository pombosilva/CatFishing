using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lifes : MonoBehaviour {

    public static int MAXLIVES = 3;
    public GameObject[] worms = new GameObject[MAXLIVES];
    private int arraySize;
    public static int lives;

    public void Start() {
        lives = MAXLIVES;
        arraySize = MAXLIVES;
    }
    public void Update(){
        if(lives == 0) {
            SceneManager.LoadScene(0);
        } else if(lives < MAXLIVES) {
            if(arraySize == lives){
                Destroy(worms[arraySize--]);
            }
        }
    }
    public static void LoseLife(){
        lives--;
    }

}
