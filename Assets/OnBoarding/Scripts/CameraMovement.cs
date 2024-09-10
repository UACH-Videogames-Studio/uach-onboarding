using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] protected float moveSpeed = 2f;

    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }
}
