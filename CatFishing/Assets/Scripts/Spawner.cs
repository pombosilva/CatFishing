using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public int level = 1;
    public TimerController timer; 
    public List<GameObject> objectsToSpawn = new List<GameObject>();
    public double timeToSpawn = 1;

    // Update is called once per frame
    void Update() {
        if(timeToSpawn > 0)
            timeToSpawn -= Time.deltaTime;
        else{
            spawnObject();
            level = timer.getLevel();
            timeToSpawn = ( level == 1 ? ProbabilityDensityFunctions.TimeBetweenObjectsL1() : ProbabilityDensityFunctions.TimeBetweenObjectsL2() );
            print(level);
        }
    }

    void spawnObject() {                 
        int index = ( level == 1 ? ProbabilityDensityFunctions.TypeOfObjectL1() : ProbabilityDensityFunctions.TypeOfObjectL2() );   //gera aleatoriamente o objeto a aparecer
        int sideToSpawn = ProbabilityDensityFunctions.Side();                                                                       //gera aleatoriamente o lado em que o objeto aparece
        float heightToSpawn = (float) ((6f/10f) * ProbabilityDensityFunctions.PositionInHeight() - 5f);                             //gera aleatoriamente a altura do objeto
        Vector3 initialPosition = new Vector3(sideToSpawn*11, heightToSpawn, 0);
        GameObject spawn = objectsToSpawn[index];

        MoveParent m = spawn.GetComponent<MoveParent>();
        m.sideToSpawn = sideToSpawn;
        
        Instantiate(spawn, initialPosition, transform.rotation);
    }
}
