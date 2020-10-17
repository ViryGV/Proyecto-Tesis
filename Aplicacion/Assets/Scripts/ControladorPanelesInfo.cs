using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPanelesInfo : MonoBehaviour
{
    public GameObject panelTarjetas;
    public GameObject panelEmociones;
    public GameObject panelAtencion;
    public GameObject panelMemoria;

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
    }

    public void ActivarPanelEmociones()
    {
        panelEmociones.SetActive(true);
        panelAtencion.SetActive(false);
        panelMemoria.SetActive(false);
    }

    public void ActivarPanelAtencion()
    {
        panelAtencion.SetActive(true);
        panelMemoria.SetActive(false);
    }

    public void ActivarPanelMemoria()
    {
        panelMemoria.SetActive(true);
    }
}
