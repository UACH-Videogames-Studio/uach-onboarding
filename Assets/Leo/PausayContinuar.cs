using UnityEngine;

public class PausayContinuar : MonoBehaviour
{
    public GameObject PanelPausa;
    void Start()
    {
        PanelPausa.SetActive(false);
    }
    public void Pausa()
    {
        Time.timeScale = 0;
        PanelPausa.SetActive(true);
    }
    public void Play()
    {
        Time.timeScale = 1;
        PanelPausa.SetActive(false);
    }
    
}