using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<GameObject> objectsToSpawn = new List<GameObject>();
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
        int index = 0;          //gera aleatoriamente o objeto a aparecer
        int sideToSpawn = -1;    //gera aleatoriamente o lado em que o objeto aparece
        float heightToSpawn = 0;//gera aleatoriamente a altura do objeto
        Vector3 initialPosition = new Vector3(sideToSpawn*11, heightToSpawn, 0);
        //TODO mudar a orientação do objeto a dar spawn consoante o lado em que aparece ???
        GameObject spawn = objectsToSpawn[index];
        spawn.transform.localScale = new Vector3(-1f*sideToSpawn, 1f, 1f);

        Instantiate(spawn, initialPosition, transform.rotation);
    }
}
