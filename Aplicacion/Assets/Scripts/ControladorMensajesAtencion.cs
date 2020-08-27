using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo del mensaje que indica cuando haz superado un nivel
/// </summary>
public class ControladorMensajesAtencion : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla del mensaje</value>
    public GameObject panelMensaje;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de nivel superado
    /// </summary>
    public void CargarPanelMensaje()
    {
        Debug.Log("Mensaje");
        StartCoroutine(EsperarPanelCargando());
    }

    public void CargarPanelMensajeComedor()
    {
        Debug.Log("Mensaje Comedor");
        StartCoroutine(EsperarPanelCargandoComedor());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla del mensaje y el menú de los niveles de atención
    /// </summary>
    public IEnumerator EsperarPanelCargando()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("NivelesAtencion");
        Time.timeScale = 1;
    }

    public IEnumerator EsperarPanelCargandoComedor()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("NivelesComedor");
        Time.timeScale = 1;
    }
}