using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    public GameObject panelPrincipal;
    public GameObject panelJuegos;
    public GameObject panelSalir;
    public GameObject panelInfo;
    public GameObject panelOpciones;
    public GameObject panelActividades;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPanelPrincipal()
    {
        panelPrincipal.SetActive (true);
        panelJuegos.SetActive(false); //Mundos
    }

    public void DesactivarPanelPrincipal()
    {
        panelPrincipal.SetActive(false);
    }

    public void ActivarPanelJuegos()
    {
        panelJuegos.SetActive(true);
        //panelPrincipal.SetActive(false);
    }

    public void DesactivarPanelJuegos()
    {
        panelPrincipal.SetActive(true);
        panelJuegos.SetActive(false);
    }

    public void ActivarPanelOpciones() //Personajes
    {
        panelOpciones.SetActive(true);
        //panelPrincipal.SetActive(false);
    }

    public void DesactivarPanelOpciones()
    {
        panelPrincipal.SetActive(true);
        panelOpciones.SetActive(false);
    }

    public void ActivarPanelInfo()
    {
        panelInfo.SetActive(true);
        //panelPrincipal.SetActive(false);
    }

    public void DesactivarPanelInfo()
    {
        panelPrincipal.SetActive(true);
        panelInfo.SetActive(false);
    }

    public void ActivarPanelSalir()
    {
        panelSalir.SetActive(true);
        //panelPrincipal.SetActive(false);
    }

    public void DesactivarPanelSalir()
    {
        panelPrincipal.SetActive(true);
        panelSalir.SetActive(false);
    }
}
