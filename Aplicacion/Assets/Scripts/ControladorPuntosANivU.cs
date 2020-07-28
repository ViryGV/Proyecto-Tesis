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
    public GameObject panelAlegria;
    public GameObject panelEnojo;
    public GameObject panelTristeza;
    public GameObject panelSopresa;
    public GameObject panelTemor;
    public GameObject panelAburrido;
    public GameObject panelPreocupado;
    public GameObject panelCansado;
    public GameObject objetoAlegria;
    public GameObject objetoEnojo;
    public GameObject objetoTristeza;
    public GameObject objetoSorpresa;
    public GameObject objetoTemor;
    public GameObject objetoAburrido;
    public GameObject objetoPreocupado;
    public GameObject objetoCansado;

    int puntajeAciertos;
    int puntajeErrores;

    ControladorJuego controladorJuego;
    /// <value>Acceder al valor de Renderer en los objetos para manipularlos</value>
    Renderer render;
    Renderer renderE;
    Renderer renderT;
    Renderer renderS;
    Renderer renderA;
    Renderer renderP;
    Renderer renderC;
    Renderer renderTemor;

    void Start()
    {
        render = objetoAlegria.GetComponent<Renderer>();
        renderE = objetoEnojo.GetComponent<Renderer>();
        renderT = objetoTristeza.GetComponent<Renderer>();
        renderS = objetoSorpresa.GetComponent<Renderer>();
        renderA = objetoAburrido.GetComponent<Renderer>();
        renderP = objetoPreocupado.GetComponent<Renderer>();
        renderTemor = objetoTemor.GetComponent<Renderer>();
        renderC = objetoCansado.GetComponent<Renderer>();
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
            DesactivarPanelAlegria();
            ActivarPanelEnojo();
        }
        if (puntajeAciertos >= 2)
        {
            Debug.Log("puntaje 2");
            DesactivarPanelEnojo();
            ActivarPanelTristeza();
        }
        if (puntajeAciertos >= 3)
        {
            Debug.Log("puntaje 3");
            DesactivarPanelTristeza();
            ActivarPanelSorpresa();
        }
        if (puntajeAciertos >= 4)
        {
            Debug.Log("puntaje 4");
            DesactivarPanelSorpresa();
            ActivarPanelTemor();
        }
        if (puntajeAciertos >= 5)
        {
            Debug.Log("puntaje 5");
            DesactivarPanelTemor();
            ActivarPanelAburrido();
        }
        if (puntajeAciertos >= 6)
        {
            Debug.Log("puntaje 6");
            DesactivarPanelAburrido();
            ActivarPanelPreocupado();
        }
        if (puntajeAciertos >= 7)
        {
            Debug.Log("puntaje 7");
            DesactivarPanelPreocupado();
            ActivarPanelCansado();
        }

        if (puntajeAciertos >= 8)
        {
            controladorJuego.DesbloquearNivel();
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

    public void ActivarPanelAlegria()
    {
        panelAlegria.SetActive(true);
        render.enabled = true;
    }

    public void DesactivarPanelAlegria()
    {
        panelAlegria.SetActive(false);
        render.enabled = false;
    }

    public void ActivarPanelEnojo()
    {
        panelEnojo.SetActive(true);
        renderE.enabled = true;
    }

    public void DesactivarPanelEnojo()
    {
        panelEnojo.SetActive(false);
        renderE.enabled = false;
    }

    public void ActivarPanelTristeza()
    {
        panelTristeza.SetActive(true);
        renderT.enabled = true;
    }

    public void DesactivarPanelTristeza()
    {
        panelTristeza.SetActive(false);
        renderT.enabled = false;
    }

    public void ActivarPanelSorpresa()
    {
        panelSopresa.SetActive(true);
        renderS.enabled = true;
    }

    public void DesactivarPanelSorpresa()
    {
        panelSopresa.SetActive(false);
        renderS.enabled = false;
    }

    public void ActivarPanelTemor()
    {
        panelTemor.SetActive(true);
        renderTemor.enabled = true;
    }

    public void DesactivarPanelTemor()
    {
        panelTemor.SetActive(false);
        renderTemor.enabled = false;
    }

    public void ActivarPanelAburrido()
    {
        panelAburrido.SetActive(true);
        renderA.enabled = true;
    }

    public void DesactivarPanelAburrido()
    {
        panelAburrido.SetActive(false);
        renderA.enabled = false;
    }

    public void ActivarPanelPreocupado()
    {
        panelPreocupado.SetActive(true);
        renderP.enabled = true;
    }

    public void DesactivarPanelPreocupado()
    {
        panelPreocupado.SetActive(false);
        renderP.enabled = false;
    }

    public void ActivarPanelCansado()
    {
        panelCansado.SetActive(true);
        renderC.enabled = true;
    }

    public void DesactivarPanelCansado()
    {
        panelCansado.SetActive(false);
        renderC.enabled = false;
    }
}