using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMensajes : MonoBehaviour
{
    public GameObject panelMensaje;

    public void CargarPanelMensaje()
    {
        Debug.Log("Mensaje");
        StartCoroutine(EsperarPanelCargando());
    }

    public IEnumerator EsperarPanelCargando()
    {
        panelMensaje.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesEmociones");
        Time.timeScale = 1;
    }
}