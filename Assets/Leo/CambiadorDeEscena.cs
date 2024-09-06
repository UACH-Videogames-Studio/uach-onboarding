using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorDeEscena : MonoBehaviour
{
    public string NombreDelNivel;
    public void CambioDeEscena()
    {
        SceneManager.LoadScene(NombreDelNivel);
    }
}
