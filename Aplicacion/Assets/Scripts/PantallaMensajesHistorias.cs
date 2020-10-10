using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo del mensaje que aparecerá al finalizar la historia
/// Puede ser un mensaje de que el usuario acerto o uno donde le indica al usuario
/// porque se equivocó
/// </summary>
public class PantallaMensajesHistorias : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla del mensaje</value>
    public GameObject panelMensajeEquivocado;
    public GameObject panelMensaje;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla del mensaje
    /// indicando porque se equivocó
    /// </summary>
    public void CargarPanelMensajeEquivocado()
    {
        StartCoroutine(EsperarPanelMensajeEquivocado());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla del mensaje y el menú de las historias
    /// </summary>
    public IEnumerator EsperarPanelMensajeEquivocado()
    {
        panelMensajeEquivocado.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MenuHistorias");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla con el mensaje de que
    /// el usuario acertó en la respuesta
    /// </summary>
    public void CargarPanelMensaje()
    {
        StartCoroutine(EsperarPanelMensaje());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla del mensaje y el menú de las historias
    /// </summary>
    public IEnumerator EsperarPanelMensaje()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MenuHistorias");
        Time.timeScale = 1;
    }
}
