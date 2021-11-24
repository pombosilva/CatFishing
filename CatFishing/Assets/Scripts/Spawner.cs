using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject smallFish;
    public GameObject bigFish;
    public float timeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = 1; //gera aleatoriamente o tempo
    }

    // Update is called once per frame
    void Update()
    {
        if(timeToSpawn > 0)
            timeToSpawn -= Time.deltaTime;
        else{
            spawnObject();
            timeToSpawn = 1;    //gera aleatoriamente o tempo
        }
    }

    void spawnObject() {
        int objectToSpawn = 0;  //gera aleatoriamente o objeto a aparecer
        int sideToSpawn = 1;    //gera aleatoriamente o lado em que o objeto aparece
        float heightToSpawn = 0;//gera aleatoriamente a altura do objeto
        Vector3 initialPosition = new Vector3(sideToSpawn*11, 0, heightToSpawn);
        switch(objectToSpawn) {
            case 0:
                //GameObject object = smallFish.GetComponent<SpriteRenderer>
                Instantiate(smallFish, initialPosition, transform.rotation);
            break;
            case 1:
                //GameObject object = smallFish.GetComponent<SpriteRenderer>
                Instantiate(bigFish, initialPosition, transform.rotation);
            break;
        } 
    }
}
