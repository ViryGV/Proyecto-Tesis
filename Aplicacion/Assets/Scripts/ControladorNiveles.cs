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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para los niveles
    /// </summary>
    public void CargarPanelNivel()
    {
        StartCoroutine(EsperarPanelCargando());
    }

    public void CargarPanelNivelAtencion()
    {
        StartCoroutine(EsperarPanelCargandoAtencion());
    }

    public void CargarPanelNivelReglasComedor()
    {
        StartCoroutine(EsperarPanelCargandoReglasComedor());
    }

    public void CargarPanelNivelReglasUrbanidad()
    {
        StartCoroutine(EsperarPanelCargandoReglasUrbanidad());
    }

    public void CargarPanelNivelInstrucciones()
    {
        StartCoroutine(EsperarPanelCargandoInstrucciones());
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
    /// se muestran la pantalla de cargando y el menú de los niveles (instrucciones visuales)
    /// </summary>
    public IEnumerator EsperarPanelCargandoInstrucciones()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesInstruccionesVisuales");
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