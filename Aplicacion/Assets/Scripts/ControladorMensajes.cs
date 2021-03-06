﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo del mensaje que indica cuando haz superado un nivel
/// </summary>
public class ControladorMensajes : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla del mensaje</value>
    public GameObject panelMensaje;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de nivel superado
    /// </summary>
    public void CargarPanelMensaje()
    {
        StartCoroutine(EsperarPanelCargando());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla del mensaje y el menú de los niveles de emociones
    /// </summary>
    public IEnumerator EsperarPanelCargando()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("NivelesEmociones");
        Time.timeScale = 1;
    }
}