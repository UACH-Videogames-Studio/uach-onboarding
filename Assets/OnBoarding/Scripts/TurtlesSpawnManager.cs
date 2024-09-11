using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtlesSpawnManager : MonoBehaviour
{
    [SerializeField] protected float minWaitTime = 2;
    [SerializeField] protected float maxWaitTime = 3;
    [SerializeField] protected TurtleSpawnPoint spawnPointLeft;
    [SerializeField] protected TurtleSpawnPoint spawnPointRight;
    protected float waitTime = 0;
    protected bool allowSpawn = true;

    // Update is called once per frame
    void Update()
    {
        if(allowSpawn){
            waitTime-=Time.deltaTime;
            // Una vez que wait time valga 0 o menos, spawneo la siguiente tortuga
            if(waitTime<=0){
                if(Random.value>0.5){
                    // Spawnear tortuga en la derecha
                    spawnPointRight.Spawn();
                }else{
                    // Spawnear tortuga en la izquierda
                    spawnPointLeft.Spawn();
                }

                // Volver a establecer el tiempo de espera
                waitTime=Random.Range(minWaitTime, maxWaitTime);
            }
        }
    }

    void Stop(){
        allowSpawn=false;
    }
}
