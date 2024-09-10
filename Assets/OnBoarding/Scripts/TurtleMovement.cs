using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovement : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField] protected bool isRightMovement = true;
    [SerializeField] protected float speed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // Establecer la velocidad en x
        if(isRightMovement == false){
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }else{
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
    }
}
