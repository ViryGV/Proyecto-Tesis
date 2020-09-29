using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarDatos : MonoBehaviour
{
    public GameObject panelMensajeExito;
    void Start()
    {

    }

    void Update()
    {

    }

    public void BorrarDatosActividades()
    {
        panelMensajeExito.SetActive(true);
        Debug.Log("Entre");
        //Emociones
        PlayerPrefs.DeleteKey("PuntajeErroresMax");
        PlayerPrefs.DeleteKey("PuntajeErroresMin");
        PlayerPrefs.DeleteKey("PuntajeErrores");
        PlayerPrefs.DeleteKey("PuntajeErroresMaxDos");
        PlayerPrefs.DeleteKey("PuntajeErroresMinDos");
        PlayerPrefs.DeleteKey("PuntajeErroresDos");
        PlayerPrefs.DeleteKey("PuntajeErroresMaxTres");
        PlayerPrefs.DeleteKey("PuntajeErroresMinTres");
        PlayerPrefs.DeleteKey("PuntajeErroresTres");
        PlayerPrefs.DeleteKey("PuntajeAciertos");
    } 

    public void CerrarMensaje()
    {
        panelMensajeExito.SetActive(false);
    }
}
