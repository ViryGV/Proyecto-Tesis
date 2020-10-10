using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase permite navegar entre el menú de las historias
/// y entre las historias existentes
/// </summary>

public class ControladorHistorias : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla de espera</value>
    public GameObject panelCargando;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para el menú de historias
    /// </summary>
    public void CargarMenuHistorias()
    {
        StartCoroutine(EsperarPanelCargandoMenuHistorias());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para la historia uno
    /// </summary>
    public void CargarHistoriaUno()
    {
        StartCoroutine(EsperarPanelCargandoHistoriaUno());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para la historia dos
    /// </summary>
    public void CargarHistoriaDos()
    {
        StartCoroutine(EsperarPanelCargandoHistoriaDos());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para la historia dos
    /// </summary>
    public void CargarHistoriaTres()
    {
        StartCoroutine(EsperarPanelCargandoHistoriaTres());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de historias
    /// </summary>
    public IEnumerator EsperarPanelCargandoMenuHistorias()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuHistorias");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y la primera historia
    /// </summary>
    public IEnumerator EsperarPanelCargandoHistoriaUno()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("HistoriaUno");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y la segunda historia
    /// </summary>
    public IEnumerator EsperarPanelCargandoHistoriaDos()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("HistoriaDos");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y la tercera historia
    /// </summary>
    public IEnumerator EsperarPanelCargandoHistoriaTres()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("HistoriaTres");
        Time.timeScale = 1;
    }
}
