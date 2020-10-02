using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorEscenaVeterinarios : MonoBehaviour
{
    public GameObject panelIniciar;
    public GameObject panelDescripcion;
    public GameObject panelPorque;
    public GameObject panelHerramientas;
    public GameObject panelFinal;
    public GameObject btnIniciar;
    public GameObject btnFinalizar;
    public GameObject imageBuho;
    public GameObject imagedialogo;

    public void ActivarPanelDescripcion()
    {
        Debug.Log("Entre");
        panelIniciar.SetActive(true);
        btnIniciar.SetActive(false);
        imageBuho.SetActive(false);
        imagedialogo.SetActive(false);
    }

    public void DesactivarPanelDescripcion()
    {
        Debug.Log("Entre");
        panelIniciar.SetActive(false);
    }

    public void ActivarPanelDescripcionDos()
    {
        Debug.Log("Entre");
        DesactivarPanelDescripcion();
        panelDescripcion.SetActive(true);
    }

    public void DesactivarPanelDescripcionDos()
    {
        Debug.Log("Entre");
        panelDescripcion.SetActive(false);
    }

    public void ActivarPanelPorque()
    {
        Debug.Log("Entre");
        DesactivarPanelDescripcionDos();
        panelPorque.SetActive(true);
    }

    public void DesactivarPanelPorque()
    {
        Debug.Log("Entre");
        panelPorque.SetActive(false);
    }

    public void ActivarPanelHerramientas()
    {
        Debug.Log("Entre");
        DesactivarPanelPorque();
        panelHerramientas.SetActive(true);
    }

    public void DesactivarPanelHerramientas()
    {
        Debug.Log("Entre");
        panelHerramientas.SetActive(false);
    }

    public void ActivarPanelFinal()
    {
        Debug.Log("Entre");
        DesactivarPanelHerramientas();
        panelFinal.SetActive(true);
        btnFinalizar.SetActive(true);
    }
}
