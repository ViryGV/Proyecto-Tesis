using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo entre el menú principal y el menú de los juegos
/// </summary>
public class ControladorNiveles : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla de espera</value>
    public GameObject panelCargando;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera 
    /// para los niveles de reconocimiento de emociones
    /// </summary>
    public void CargarPanelNivel()
    {
        StartCoroutine(EsperarPanelCargando());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera 
    /// para los niveles de atención
    /// </summary>
    public void CargarPanelNivelAtencion()
    {
        StartCoroutine(EsperarPanelCargandoAtencion());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera 
    /// para los niveles de intrucciones visuales 
    /// (parte reglas del comedor)
    /// </summary>
    public void CargarPanelNivelReglasComedor()
    {
        StartCoroutine(EsperarPanelCargandoReglasComedor());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera 
    /// para los niveles de intrucciones visuales 
    /// (parte reglas de urbanidad)
    /// </summary>
    public void CargarPanelNivelReglasUrbanidad()
    {
        StartCoroutine(EsperarPanelCargandoReglasUrbanidad());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera 
    /// para los niveles de intrucciones visuales 
    /// (parte reglas del salón de clases)
    /// </summary>
    public void CargarPanelNivelReglasEscuela()
    {
        StartCoroutine(EsperarPanelCargandoReglasEscuela());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera 
    /// para los niveles de memoria de trabajo
    /// </summary>
    public void CargarPanelNivelMemoria()
    {
        StartCoroutine(EsperarPanelCargandoMemoria());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera
    /// para los niveles de operaciones de suma
    /// </summary>
    public void CargarSumar()
    {
        StartCoroutine(EsperarPanelCargandoSumar());
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para el menú de juegos
    /// </summary>
    public void CargarMenuJuegos()
    {
        StartCoroutine(EsperarPanelCargandoJuegos());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de los niveles (emociones)
    /// </summary>
    public IEnumerator EsperarPanelCargando()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesEmociones");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de los niveles (atención)
    /// </summary>
    public IEnumerator EsperarPanelCargandoAtencion()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesAtencion");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de los niveles (reglas del comedor)
    /// </summary>
    public IEnumerator EsperarPanelCargandoReglasComedor()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesComedor");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de los niveles (reglas del comedor)
    /// </summary>
    public IEnumerator EsperarPanelCargandoReglasUrbanidad()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesUrbanidad");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de los niveles (reglas del comedor)
    /// </summary>
    public IEnumerator EsperarPanelCargandoReglasEscuela()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesEscuela");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de los niveles (reglas del comedor)
    /// </summary>
    public IEnumerator EsperarPanelCargandoMemoria()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesMemoria");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de los niveles (sumar)
    /// </summary>
    public IEnumerator EsperarPanelCargandoSumar()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesSumar");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de juegos
    /// </summary>
    public IEnumerator EsperarPanelCargandoJuegos()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuJuegos");
        Time.timeScale = 1;
    }
}