using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class PantallaDeCarga : MonoBehaviour
{
    public float TiempoDeEspera;
    public TMP_Text TextoDelTiempo;
    public Image Circulo;
    public GameObject TiempoDeEsperaPanel;
    public PausayContinuar pausayContinuar;
    float TiempoActual = 0;
    void Start()
    {
        Circulo.GetComponent<Image>();
        Circulo.fillAmount = 0;
        Time.timeScale = 0;
    }
    void Update()
    {
        TiempoActual = TiempoActual + Time.fixedDeltaTime;
        TextoDelTiempo.text = TiempoActual.ToString("F1");
        Circulo.fillAmount = TiempoActual/TiempoDeEspera;
        if (TiempoActual>TiempoDeEspera)
        {
            TiempoDeEsperaPanel.SetActive(false);
            pausayContinuar.Play();
        }
    }
}
