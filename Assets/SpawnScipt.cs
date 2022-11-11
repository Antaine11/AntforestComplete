using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScipt : MonoBehaviour 
{

    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    private void Start() {
        spawnParticleSmoke();
    
        
    }
    void spawnParticleSmoke(){

      
       whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0));
       whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[0], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0));
       whatToSpawnClone[2] = Instantiate(whatToSpawnPrefab[0], spawnLocations[2].transform.position, Quaternion.Euler(0, 0, 0));
       whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[3], spawnLocations[3].transform.position, Quaternion.Euler(0, 0, 0));
       whatToSpawnClone[4] = Instantiate(whatToSpawnPrefab[4], spawnLocations[4].transform.position, Quaternion.Euler(0, 0, 0));
       whatToSpawnClone[5] = Instantiate(whatToSpawnPrefab[5], spawnLocations[5].transform.position, Quaternion.Euler(0, 0, 0));
       whatToSpawnClone[6] = Instantiate(whatToSpawnPrefab[6], spawnLocations[6].transform.position, Quaternion.Euler(0, 0, 0));
       whatToSpawnClone[7] = Instantiate(whatToSpawnPrefab[7], spawnLocations[7].transform.position, Quaternion.Euler(0, 0, 0));
    }
    
  

}
