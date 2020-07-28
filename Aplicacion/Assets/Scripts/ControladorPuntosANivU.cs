using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControladorPuntosANivU : MonoBehaviour
{
    public TextMeshProUGUI textoAciertos;
    //public Text textoErrores;
    public TextMeshProUGUI textoMensaje;
    public GameObject cosmo;
    public GameObject panelUno;
    public GameObject panelDos;
    public GameObject panelTres;
    public GameObject panelCuatro;
    public GameObject panelCinco;
    public GameObject panelSeis;
    public GameObject objetoUno;
    public GameObject objetoDos;
    public GameObject objetoTres;
    public GameObject objetoCuatro;
    public GameObject objetoCinco;
    public GameObject objetoSeis;

    int puntajeAciertos;
    int puntajeErrores;

    ControladorJuego controladorJuego;

    /// <value>Acceder al valor de Renderer en los objetos para manipularlos</value>
    Renderer renderUno;
    Renderer renderDos;
    Renderer renderTres;
    Renderer renderCuatro;
    Renderer renderCinco;
    Renderer renderSeis;

    void Start()
    {
        renderUno = objetoUno.GetComponent<Renderer>();
        renderDos = objetoDos.GetComponent<Renderer>();
        renderTres = objetoTres.GetComponent<Renderer>();
        renderCuatro = objetoCuatro.GetComponent<Renderer>();
        renderCinco = objetoCinco.GetComponent<Renderer>();
        renderSeis = objetoSeis.GetComponent<Renderer>();
    }

    void Awake()
    {
        controladorJuego = GameObject.Find("ControladorJuego").GetComponent(typeof(ControladorJuego)) as ControladorJuego;
    }

    public void SumarPuntaje()
    {
        puntajeAciertos += 1;
        ActualizarTextoPuntaje();
        ActivarStatus();

        if (puntajeAciertos >= 1)
        {
            Debug.Log("puntaje 1");
            DesactivarPanelUno();
            ActivarPanelDos();
        }
        if (puntajeAciertos >= 2)
        {
            Debug.Log("puntaje 2");
            DesactivarPanelDos();
            ActivarPanelTres();
        }
        if (puntajeAciertos >= 3)
        {
            Debug.Log("puntaje 3");
            DesactivarPanelTres();
            ActivarPanelCuatro();
        }
        if (puntajeAciertos >= 4)
        {
            Debug.Log("puntaje 4");
            DesactivarPanelCuatro();
            ActivarPanelCinco();
        }
        if (puntajeAciertos >= 5)
        {
            Debug.Log("puntaje 5");
            DesactivarPanelCinco();
            ActivarPanelSeis();
        }
        if (puntajeAciertos >= 6)
        {
            controladorJuego.DesbloquearNivelAtencion();
        }
    }

    public void RestarPuntaje()
    {
        puntajeErrores += 1;
        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    void ActualizarTextoPuntaje()
    {
        textoAciertos.text = "Aciertos " + puntajeAciertos.ToString();
        //textoErrores.text = "Errores " + puntajeErrores.ToString();
    }

    public void ActivarStatus()
    {
        textoMensaje.enabled = true;
        cosmo.SetActive(true);
        textoMensaje.text = "Bien Hecho";
    }

    public void ActivarPistas()
    {
        textoMensaje.enabled = true;
        cosmo.SetActive(true);
        textoMensaje.text = "Intentalo de nuevo";
    }

    public void ActivarPanelUno()
    {
        panelUno.SetActive(true);
    }

    public void DesactivarPanelUno()
    {
        panelUno.SetActive(false);
    }

    public void ActivarPanelDos()
    {
        panelDos.SetActive(true);
        renderUno.enabled = true;
        renderDos.enabled = true;
    }

    public void DesactivarPanelDos()
    {
        panelDos.SetActive(false);
        renderDos.enabled = false;
    }

    public void ActivarPanelTres()
    {
        panelTres.SetActive(true);
        renderTres.enabled = true;
    }

    public void DesactivarPanelTres()
    {
        panelTres.SetActive(false);
        renderTres.enabled = false;
    }

    public void ActivarPanelCuatro()
    {
        panelCuatro.SetActive(true);
        renderCuatro.enabled = true;
    }

    public void DesactivarPanelCuatro()
    {
        panelCuatro.SetActive(false);
        renderCuatro.enabled = false;
    }

    public void ActivarPanelCinco()
    {
        panelCinco.SetActive(true);
        renderCinco.enabled = true;
    }

    public void DesactivarPanelCinco()
    {
        panelCinco.SetActive(false);
        renderCinco.enabled = false;
    }

    public void ActivarPanelSeis()
    {
        panelSeis.SetActive(true);
        renderSeis.enabled = true;
    }

    public void DesactivarPanelSeis()
    {
        panelSeis.SetActive(false);
        renderSeis.enabled = false;
    }
}