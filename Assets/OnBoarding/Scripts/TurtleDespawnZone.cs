using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleDespawnZone : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Turtle"))
        {
            Debug.Log("Despawneo la tortuga");
            Destroy(other.gameObject);
        }
    }
}
