using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 2f;
    [SerializeField] protected float rotationSpeed = 2f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -rotationSpeed);
        }
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
