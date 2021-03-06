﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo entre el menú principal y el menú de los juegos
/// </summary>
public class ControladorMenu : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla de espera</value>
    public GameObject panelCargando;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para el menú principal
    /// </summary>
    public void CargarMenu()
    {
        StartCoroutine(EsperarPanelCargando());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú principal
    /// </summary>
    public IEnumerator EsperarPanelCargando()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
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
    /// se muestran la pantalla de cargando y el menú de juegos
    /// </summary>
    public IEnumerator EsperarPanelCargandoJuegos()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuJuegos");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Permite cambiar la escenar para dar acceso a la
    /// opción de progreso
    /// </summary>
    public void CargarProgreso()
    {
        SceneManager.LoadScene("InformacionProgreso");
    }
}