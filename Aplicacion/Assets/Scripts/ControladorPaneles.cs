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
    public GameObject panelHistorias;
    public GameObject panelProgreso;
    public GameObject panelProfesiones;
    public GameObject panelMatematicas;

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

    public void ActivarPanelProgreso()
    {
        panelProgreso.SetActive(true);
    }

    public void DesactivarPanelProgreso()
    {
        panelPrincipal.SetActive(true);
        panelProgreso.SetActive(false);
    }

    public void ActivarPanelActividades()
    {
        panelActividades.SetActive(true);
    }

    public void DesactivarPanelActividades()
    {
        panelJuegos.SetActive(true);
        panelActividades.SetActive(false);
    }

    public void DesactivarPanelActividadesJuegos()
    {
        panelPrincipal.SetActive(true);
        panelActividades.SetActive(false);
        panelJuegos.SetActive(false);
    }

    public void ActivarPanelHistorias()
    {
        panelHistorias.SetActive(true);
    }

    public void DesactivarPanelHistorias()
    {
        panelJuegos.SetActive(true);
        panelHistorias.SetActive(false);
    }

    public void DesactivarPanelHistoriasJuegos()
    {
        panelPrincipal.SetActive(true);
        panelHistorias.SetActive(false);
        panelJuegos.SetActive(false);
    }

    public void ActivarPanelProfesiones()
    {
        panelProfesiones.SetActive(true);
    }

    public void DesactivarPanelProfesiones()
    {
        panelJuegos.SetActive(true);
        panelProfesiones.SetActive(false);
    }

    public void DesactivarPanelProfesionesJuegos()
    {
        panelPrincipal.SetActive(true);
        panelProfesiones.SetActive(false);
        panelJuegos.SetActive(false);
    }

    public void ActivarPanelMatematicas()
    {
        panelMatematicas.SetActive(true);
    }

    public void DesactivarPanelMatematicas()
    {
        panelJuegos.SetActive(true);
        panelMatematicas.SetActive(false);
    }

    public void DesactivarPanelMatematicasJuegos()
    {
        panelPrincipal.SetActive(true);
        panelMatematicas.SetActive(false);
        panelJuegos.SetActive(false);
    }
}
