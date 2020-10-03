using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo que permite borrar
/// la información del juego (reiniciar los niveles
/// o restablecer los valores del progreso)
/// </summary>
public class BorrarDatos : MonoBehaviour
{
    /// <value>Establece el valor del panel indicando un mensaje de se restablecieron
    /// los valores en progreso</value>
    public GameObject panelMensajeExito;

    /// <summary>
    /// Método que se encarga de restablecer en cero la información de progreso
    /// </summary>
    public void BorrarDatosActividades()
    {
        panelMensajeExito.SetActive(true);
        Debug.Log("Entre");
        //Emociones
        PlayerPrefs.DeleteKey("PuntajeErroresMax");
        PlayerPrefs.DeleteKey("PuntajeErroresMin");
        PlayerPrefs.DeleteKey("PuntajeErrores");
        PlayerPrefs.DeleteKey("PuntajeErroresActualesDos");
        PlayerPrefs.DeleteKey("PuntajeErroresAnterioresDos");
        PlayerPrefs.DeleteKey("PuntajeErroresDos");
        PlayerPrefs.DeleteKey("PuntajeErroresMaxTres");
        PlayerPrefs.DeleteKey("PuntajeErroresMinTres");
        PlayerPrefs.DeleteKey("PuntajeErroresTres");
        PlayerPrefs.DeleteKey("PuntajeAciertos");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMax");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMin");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMaxDos");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMinDos");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMaxTres");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMinTres");
        PlayerPrefs.DeleteKey("PuntajeAciertosHistoriasUno");
        PlayerPrefs.DeleteKey("PuntajeAciertosHistoriaDos");
        PlayerPrefs.DeleteKey("PuntajeAciertos");
    }

    /// <summary>
    /// Método que se encarga de cerrar el mensaje que aparece en pantalla
    /// </summary>
    public void CerrarMensaje()
    {
        panelMensajeExito.SetActive(false);
    }
}
