using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarDatos : MonoBehaviour
{
    [SerializeField]
    private InterfazMensaje interfazDeUsuario;

    [SerializeField]
    private string mensajeSalteableBoton;

    void Start()
    {
        interfazDeUsuario = FindObjectOfType<InterfazMensaje>();
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Tecla 3 pulsada");
            interfazDeUsuario.MostrarMensajeSalteableBoton(mensajeSalteableBoton);
        }
        */
        if (Input.anyKeyDown)
        {
            interfazDeUsuario.MostrarMensajeSalteableBoton(mensajeSalteableBoton);
        }
    }

    public void BorrarDatosActividades()
    {
        Debug.Log("Entre");
        interfazDeUsuario.MostrarMensajeSalteableBoton(mensajeSalteableBoton);
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
}
