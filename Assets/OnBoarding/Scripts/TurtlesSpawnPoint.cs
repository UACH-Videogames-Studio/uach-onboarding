using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleSpawnPoint : MonoBehaviour
{
    [SerializeField] protected bool isRightMovement = true;

    [SerializeField] protected Transform container;

    [SerializeField] protected GameObject turtlePrefab;
    
    public void Spawn(){
        Vector3 position = new Vector3(
            transform.position.x,
            GetRandomHeightPosition(transform.position.y),
            transform.position.z
        );

        GameObject turtle = Instantiate(
            // Que quiero spawnear (instanciar)
            turtlePrefab,
            // Espacialmente donde lo quiero spawnear
            position,
            // Con que rotacion
            turtlePrefab.transform.rotation,
            // De quien va a ser hijo (jerarquicamente, donde lo quiero spawnear)
            container
        );

        TurtleMovement turtleMovement = turtle.GetComponent<TurtleMovement>();
        turtleMovement.isRightMovement=isRightMovement;
    }

    // Obtiene un valor aleatorio dentro de el rango de altura
    // delimitado por la posicion y de el spawnpoint, y la mitad
    // de la altura de nuestra camara.
    float GetRandomHeightPosition(float origin){
        float cameraHalfHeight=Camera.main.orthographicSize;
        
        float min=origin;
        float max=origin+cameraHalfHeight+2;
        
        float randomValue=Random.Range(min, max);

        return randomValue;
    }
}
