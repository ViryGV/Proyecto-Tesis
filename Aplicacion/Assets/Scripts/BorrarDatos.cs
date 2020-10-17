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
    public void BorrarTodosDatos()
    {
        panelMensajeExito.SetActive(true);

        //Errores Emociones
        PlayerPrefs.DeleteKey("PuntajeErroresActuales");
        PlayerPrefs.DeleteKey("PuntajeErroresMin");
        PlayerPrefs.DeleteKey("PuntajeErrores");
        PlayerPrefs.DeleteKey("PuntajeErroresActualesDos");
        PlayerPrefs.DeleteKey("PuntajeErroresAnterioresDos");
        PlayerPrefs.DeleteKey("PuntajeErroresMinDos");
        PlayerPrefs.DeleteKey("PuntajeErroresDos");
        PlayerPrefs.DeleteKey("PuntajeErroresActualesTres");
        PlayerPrefs.DeleteKey("PuntajeErroresMinTres");
        PlayerPrefs.DeleteKey("PuntajeErroresTres");

        //Aciertos Emociones
        PlayerPrefs.DeleteKey("PuntajeAciertosEUno");
        PlayerPrefs.DeleteKey("PuntajeAciertosEDos");
        PlayerPrefs.DeleteKey("PuntajeAciertosETres");

        //Errores Atención
        PlayerPrefs.DeleteKey("PuntajeErroresAtencionActuales");
        PlayerPrefs.DeleteKey("PuntajeErroresAtencion");
        PlayerPrefs.DeleteKey("PuntajeErroresAtencionMin");
        PlayerPrefs.DeleteKey("PuntajeErroresAtencionActualesDos");
        PlayerPrefs.DeleteKey("PuntajeErroresAtencionDos");
        PlayerPrefs.DeleteKey("PuntajeErroresAtencionMinDos");
        PlayerPrefs.DeleteKey("PuntajeErroresAtencionActualesTres");
        PlayerPrefs.DeleteKey("PuntajeErroresAtencionTres");
        PlayerPrefs.DeleteKey("PuntajeErroresAtencionMinTres");

        //Aciertos Atención
        PlayerPrefs.DeleteKey("PuntajeAciertosAUno");
        PlayerPrefs.DeleteKey("PuntajeAciertosADos");
        PlayerPrefs.DeleteKey("PuntajeAciertosATres");

        //Errores Memoria
        PlayerPrefs.DeleteKey("PuntajeErroresMemoriaActuales");
        PlayerPrefs.DeleteKey("PuntajeErroresMemoria");
        PlayerPrefs.DeleteKey("PuntajeErroresMemoriaMin");
        PlayerPrefs.DeleteKey("PuntajeErroresMemoriaActualesDos");
        PlayerPrefs.DeleteKey("PuntajeErroresMemoriaDos");
        PlayerPrefs.DeleteKey("PuntajeErroresMemoriaMinDos");
        PlayerPrefs.DeleteKey("PuntajeErroresMemoriaActualesTres");
        PlayerPrefs.DeleteKey("PuntajeErroresMemoriaTres");
        PlayerPrefs.DeleteKey("PuntajeErroresMemoriaMinTres");

        //Aciertos Memoria
        PlayerPrefs.DeleteKey("PuntajeAciertosMUno");
        PlayerPrefs.DeleteKey("PuntajeAciertosMDos");
        PlayerPrefs.DeleteKey("PuntajeAciertosMTres");

        //Errores de historias
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMax");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMin");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMaxDos");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMinDos");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMaxTres");
        PlayerPrefs.DeleteKey("PuntajeErroresHistoriasMinTres");
        PlayerPrefs.DeleteKey("PuntajeAciertosHistoriasUno");
        PlayerPrefs.DeleteKey("PuntajeAciertosHistoriaDos");  
    }

    /// <summary>
    /// Método que se encarga de cerrar el mensaje que aparece en pantalla
    /// </summary>
    public void CerrarMensaje()
    {
        panelMensajeExito.SetActive(false);
    }
}
