using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovement : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField] protected bool isRightMovement = true;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        // Establecer la velocidad en x
        rb.velocity=new Vector2(5,rb.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
