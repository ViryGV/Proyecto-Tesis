using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo del puntaje para superar un nivel de atención
/// Además de activar y desactivar los componentes necesarios para superar el nivel
/// </summary>
public class ControladorPuntosHistorias : MonoBehaviour
{
    /// <value>Establece el valor de los aciertos que será mostrado en pantalla</value>
    public TextMeshProUGUI textoAciertos;
    public TextMeshProUGUI textoErrores;
    /// <value>Establece el valor del texto que será mostrado en pantalla como una ayuda</value>
    public TextMeshProUGUI textoMensaje;
    public GameObject tobi;

    /// <value>Establece el valor de las veces que aciertas</value>
    int puntajeAciertos;
    /// <value>Establece el valor de las veces que el usuario se ha equivocado</value>
    int puntajeErrores;

    PantallaMensajesHistorias mensajes;

    /// <summary>
    /// Permite encontrar y asegurar que existe la clase a la que se quiere acceder
    /// </summary>
    void Awake()
    {
        mensajes = GetComponent<PantallaMensajesHistorias>();
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntaje()
    {
        puntajeAciertos++;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 1)
        {
            mensajes.CargarPanelMensaje();
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario se ha equivocado
    /// </summary>
    public void RestarPuntaje()
    {
        puntajeErrores += 1;
        ActualizarTextoPuntaje();
        ActivarPistas();

        if (puntajeErrores >= 3)
        {
            mensajes.CargarPanelMensajeEquivocado();
        }
    }

    /// <summary>
    /// Muestra en pantalla los puntos que el usuario va obteniendo
    /// </summary>
    void ActualizarTextoPuntaje()
    {
        textoAciertos.text = "Aciertos " + puntajeAciertos.ToString();
        textoErrores.text = "Errores " + puntajeErrores.ToString();
    }

    /// <summary>
    /// Método que le indica al usuario cuando acierta
    /// </summary>
    public void ActivarStatus()
    {
        textoMensaje.enabled = true;
        tobi.SetActive(true);
        textoMensaje.text = "Bien Hecho";
    }

    /// <summary>
    /// Método que le indica al usuario que ha se equivocado
    /// </summary>
    public void ActivarPistas()
    {
        textoMensaje.enabled = true;
        tobi.SetActive(true);
        textoMensaje.text = "Intentalo de nuevo";
    }
}
