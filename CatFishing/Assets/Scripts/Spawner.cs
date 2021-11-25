using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<GameObject> objectsToSpawn = new List<GameObject>();
    public double timeToSpawn;

    // Start is called before the first frame update
    void Start() {
        timeToSpawn = ProbabilityDensityFunctions.TimeBetweenObjectsL1();               //gera aleatoriamente o tempo
    }

    // Update is called once per frame
    void Update() {
        if(timeToSpawn > 0)
            timeToSpawn -= Time.deltaTime;
        else{
            spawnObject();
            timeToSpawn = ProbabilityDensityFunctions.TimeBetweenObjectsL1();           //gera aleatoriamente o tempo
        }
    }

    void spawnObject() {
        int index = ProbabilityDensityFunctions.TypeOfObjectL1();                       //gera aleatoriamente o objeto a aparecer
        if(index>1)
            index=1;
        int sideToSpawn = ProbabilityDensityFunctions.Side();                           //gera aleatoriamente o lado em que o objeto aparece
        float heightToSpawn = (float) ((6f/10f) * ProbabilityDensityFunctions.PositionInHeight() - 5f);   //gera aleatoriamente a altura do objeto
        Vector3 initialPosition = new Vector3(sideToSpawn*11, heightToSpawn, 0);
        GameObject spawn = objectsToSpawn[index];

        MoveParent m = spawn.GetComponent<MoveParent>();
        m.sideToSpawn = sideToSpawn;
        Instantiate(spawn, initialPosition, transform.rotation);
    }
}
