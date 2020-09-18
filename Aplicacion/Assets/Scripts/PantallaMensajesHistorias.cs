using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo del mensaje que indica cuando haz superado un nivel
/// </summary>
public class PantallaMensajesHistorias : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla del mensaje</value>
    public GameObject panelMensajeEquivocado;
    public GameObject panelMensaje;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de nivel superado
    /// </summary>
    public void CargarPanelMensajeEquivocado()
    {
        Debug.Log("Mensaje");
        StartCoroutine(EsperarPanelMensajeEquivocado());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla del mensaje y el menú de los niveles de atención
    /// </summary>
    public IEnumerator EsperarPanelMensajeEquivocado()
    {
        panelMensajeEquivocado.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MenuHistorias");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de nivel superado
    /// </summary>
    public void CargarPanelMensaje()
    {
        Debug.Log("Mensaje");
        StartCoroutine(EsperarPanelMensaje());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla del mensaje y el menú de los niveles de atención
    /// </summary>
    public IEnumerator EsperarPanelMensaje()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MenuHistorias");
        Time.timeScale = 1;
    }
}
