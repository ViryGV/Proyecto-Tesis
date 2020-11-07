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
    /// Activa la corrutina para cargar la pantalla del 
    /// nivel superado en atención
    /// </summary>
    public void CargarPanelMensaje()
    {
        StartCoroutine(EsperarPanelCargando());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla del
    /// nivel superado en reglas de urbanidad
    /// </summary>
    public void CargarPanelMensajeUrbanidad()
    {
        StartCoroutine(EsperarPanelCargandoUrbanidad());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla del
    /// nivel superado en reglas del comedor
    /// </summary>
    public void CargarPanelMensajeComedor()
    {
        StartCoroutine(EsperarPanelCargandoComedor());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla del
    /// nivel superado en reglas del salón de clases
    /// </summary>
    public void CargarPanelMensajeEscuela()
    {
        StartCoroutine(EsperarPanelCargandoEscuela());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla del
    /// nivel superado en memoria de trabajo
    /// </summary>
    public void CargarPanelMensajeMemoria()
    {
        StartCoroutine(EsperarPanelCargandoMemoria());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla del
    /// nivel superado en razonamiento matemático (sumar)
    /// </summary>
    public void CargarPanelMensajeSumar()
    {
        StartCoroutine(EsperarPanelCargandoSumar());
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

    public IEnumerator EsperarPanelCargandoUrbanidad()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("NivelesUrbanidad");
        Time.timeScale = 1;
    }

    public IEnumerator EsperarPanelCargandoComedor()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("NivelesComedor");
        Time.timeScale = 1;
    }

    public IEnumerator EsperarPanelCargandoEscuela()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("NivelesEscuela");
        Time.timeScale = 1;
    }

    public IEnumerator EsperarPanelCargandoMemoria()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("NivelesMemoria");
        Time.timeScale = 1;
    }

    public IEnumerator EsperarPanelCargandoSumar()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("NivelesSumar");
        Time.timeScale = 1;
    }
}