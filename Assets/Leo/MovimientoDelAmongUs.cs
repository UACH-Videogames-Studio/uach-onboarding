using UnityEngine;

public class MovimientoDelAmongUs : MonoBehaviour
{
    public float VelocidadMovimiento = 1.7f;
    void Update()
    {
        transform.Translate(Vector3.right * VelocidadMovimiento * Time.deltaTime);
    }
}
