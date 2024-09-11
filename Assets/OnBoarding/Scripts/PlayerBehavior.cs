using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 2f;
    [SerializeField] protected float rotationSpeed = 2f;

    void Update()
    {
        Vector2 input = InputMovementPC();
        transform.Translate(Vector2.up * input.y * moveSpeed * Time.deltaTime);
        transform.Rotate(0, 0, rotationSpeed*-input.x);
    }
    Vector2 InputMovementMobile(){
        Vector2 input = Vector2.zero;
        // Capturar input desde el celular
        return input;
    }
    Vector2 InputMovementPC()
    {
        Vector2 input = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            input.y = 1;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            input.y = -1;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            input.x = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            input.x = 1;
        }

        return input;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Turtle"))
        {
            Debug.Log("TE MATO LA TORTUGA");
            Destroy(gameObject);
        }
        if (other.CompareTag("Killzone"))
        {
            Debug.Log("TE PERDISTE EN EL OCEANO");
            Destroy(gameObject);
        }
    }
}
