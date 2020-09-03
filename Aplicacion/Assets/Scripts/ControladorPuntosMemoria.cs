﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControladorPuntosMemoria : MonoBehaviour
{
    /// <value>Establece el valor de los aciertos que será mostrado en pantalla</value>
    public TextMeshProUGUI textoAciertos;
    public TextMeshProUGUI textoErrores;
    /// <value>Establece el valor del texto que será mostrado en pantalla como una ayuda</value>
    public TextMeshProUGUI textoMensaje;

    /// <summary>
    /// <list type="bullet">
    /// <item>
    /// <term>cosmo</term>
    /// <description>Aparecerá cuando el usario acierte o falle</description>
    /// </item>
    /// <item>
    /// <term>panelUno</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelDos</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelTres</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelCuatro</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>objetoUno</term>
    /// <description>Es un elemento que contiene el sprite (imagen) del objeto</description>
    /// </item>
    /// <item>
    /// <term>objetoDos</term>
    /// <description>Es un elemento que contiene el sprite (imagen) del objeto</description>
    /// </item>
    /// <item>
    /// <term>objetoTres</term>
    /// <description>Es un elemento que contiene el sprite (imagen) del objeto</description>
    /// </item>
    /// </list>
    /// </summary>
    public GameObject cosmo;
    public GameObject objetoDos;
    public GameObject objetoTres;
    public GameObject botonUno;
    public GameObject botonDos;
    public GameObject botonTres;
    public GameObject panelUno;
    public GameObject panelDos;
    public GameObject panelTres;
    public GameObject panelParteUno;
    public GameObject panelParteDos;
    public GameObject panelParteTres;

    /// <value>Establece el valor de las veces que aciertas</value>
    int puntajeAciertos;
    /// <value>Establece el valor de las veces que el usuario se ha equivocado</value>
    int puntajeErrores;
    /// <value>Establece el valor flotante del tiempo de vida que tiene en pantalla los cuadros de diálogo</value>
    float tiempoVida;

    /// <value>Permite al acceso de los datos de la clase</value>
    ControladorJuego controladorJuego;
   
    /// <summary>
    /// Inicializa las variables establecidas
    /// </summary>
    void Start()
    {

    }

    /// <summary>
    /// Permite encontrar y asegurar que existe la clase a la que se quiere acceder
    /// </summary>
    void Awake()
    {
        controladorJuego = GameObject.Find("ControladorJuego").GetComponent(typeof(ControladorJuego)) as ControladorJuego;
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntaje()
    {
        puntajeAciertos += 1;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 1)
        {
            Debug.Log("puntaje 1");
            DesactivarPanelUno();
            ActivarPanelParteDos();
        }
        if (puntajeAciertos >= 2)
        {
            Debug.Log("if 2");
            Debug.Log("puntaje 2");
            DesactivarPanelDos();
            ActivarPanelParteTres();
        }
        
        if (puntajeAciertos >= 3)
        {
            Debug.Log("if 3");
            Debug.Log("puntaje 3");
            DesactivarPanelTres();
            controladorJuego.DesbloquearNivelMemoria();
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario se ha equivocado
    /// </summary>
    public void RestarPuntaje()
    {
        puntajeErrores += 1;
        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    /// <summary>
    /// Muestra en pantalla los puntos que el usuario va obteniendo
    /// </summary>
    void ActualizarTextoPuntaje()
    {
        textoAciertos.text = "Aciertos " + puntajeAciertos.ToString();
        textoErrores.text = "Errores " + puntajeErrores.ToString();
    }

    /// <summary>
    /// Método que le indica al usuario cuando acierta
    /// </summary>
    public void ActivarStatus()
    {
        textoMensaje.enabled = true;
        cosmo.SetActive(true);
        textoMensaje.text = "Bien Hecho";
    }

    /// <summary>
    /// Método que le indica al usuario que ha se equivocado
    /// </summary>
    public void ActivarPistas()
    {
        textoMensaje.enabled = true;
        cosmo.SetActive(true);
        textoMensaje.text = "Intentalo de nuevo";
    }

    public void ActivarPanelUno()
    {
        panelUno.SetActive(true);
        botonUno.SetActive(false);
    }

    public void DesactivarPanelUno()
    {
        panelUno.SetActive(false);
        objetoDos.SetActive(true);
        botonDos.SetActive(true);
    }

    public void ActivarPanelDos()
    {
        panelDos.SetActive(true);
        botonDos.SetActive(false);
    }

    public void DesactivarPanelDos()
    {
        panelDos.SetActive(false);
        objetoTres.SetActive(true);
        botonTres.SetActive(true);
        botonDos.SetActive(false);
    }

    public void ActivarPanelTres()
    {
        panelTres.SetActive(true);
        botonDos.SetActive(false);
        botonTres.SetActive(false);
    }

    public void DesactivarPanelTres()
    {
        panelTres.SetActive(false);
    }

    public void DesactivarPanelParteUno()
    {
        panelParteUno.SetActive(false);
    }

    public void ActivarPanelParteDos()
    {
        panelParteDos.SetActive(true);
    }

    public void DesactivarPanelParteDos()
    {
        panelParteDos.SetActive(false);
    }

    public void ActivarPanelParteTres()
    {
        panelParteTres.SetActive(true);
    }

    public void DesactivarPanelParteTres()
    {
        panelParteTres.SetActive(false);
    }
}
