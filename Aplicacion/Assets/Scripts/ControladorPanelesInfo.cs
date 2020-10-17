using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPanelesInfo : MonoBehaviour
{
    public GameObject panelTarjetas;
    public GameObject panelEmociones;
    public GameObject panelAtencion;
    public GameObject panelMemoria;
    public GameObject panelInstrucciones;
    public GameObject barraHistorias;

    public void ActivarPanelActividades()
    {
        panelTarjetas.SetActive(true);
    }

    public void DesactivarPanelActividades()
    {
        panelTarjetas.SetActive(false);
        panelEmociones.SetActive(false);
        panelAtencion.SetActive(false);
        panelMemoria.SetActive(false);
        panelInstrucciones.SetActive(false);
        barraHistorias.SetActive(false);
    }

    public void ActivarPanelEmociones()
    {
        panelEmociones.SetActive(true);
        panelAtencion.SetActive(false);
        panelMemoria.SetActive(false);
        panelInstrucciones.SetActive(false);
    }

    public void ActivarPanelAtencion()
    {
        panelAtencion.SetActive(true);
        panelMemoria.SetActive(false);
        panelInstrucciones.SetActive(false);
    }

    public void ActivarPanelMemoria()
    {
        panelMemoria.SetActive(true);
        panelInstrucciones.SetActive(false);
    }

    public void ActivarPanelInstrucciones()
    {
        panelInstrucciones.SetActive(true);
    }
}
