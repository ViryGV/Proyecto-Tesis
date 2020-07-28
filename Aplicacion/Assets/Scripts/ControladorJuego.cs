using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ControladorJuego : MonoBehaviour
{
    static public int nivelesDisponibles;
    static public int nivelesDisponiblesAtencion;

    public int nivelAcutal;
    public int nivelAcutalAtencion;

    public Button[] botonesMenuEmociones;
    public Button[] botonesMenuAtencion;

    CargarGuardar cargar_guardar;
    ControladorMensajes mensaje;

    void Awake()
    {
        cargar_guardar = GetComponent<CargarGuardar>();
        mensaje = GetComponent<ControladorMensajes>();
    }

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "NivelesEmociones")
        {
            Debug.Log("Emociones");
            cargar_guardar.Guardar();
            ActualizarBotones();
        } else if (SceneManager.GetActiveScene().name == "NivelesAtencion")
        {
            Debug.Log("Atencion");
            cargar_guardar.Guardar();
            ActualizarBotonesAtencion();
        }
    }

    public void ActualizarNivelEmociones(int nivel)
    {
        if (nivel == 0)
        {
            Debug.Log("Menu emociones");
            SceneManager.LoadScene("NivelesEmociones");
        }
        else
        {
            SceneManager.LoadScene("EmocionesNivel" + nivel);
        }
    }

    public void ActualizarNivelAtencion(int nivel)
    {
        Debug.Log("Actualizar atencion");
        if (nivel == 0)
        {
            Debug.Log("Menu");
            SceneManager.LoadScene("NivelesAtencion");
        }
        else
        {
            SceneManager.LoadScene("AtencionNivel" + nivel);
        }
    }

    public void PantallaMensaje()
    {
        Debug.Log("Esperando");
        mensaje.CargarPanelMensaje();
    }

    public void DesbloquearNivel()
    {
        if (nivelesDisponibles < nivelAcutal)
        {
            nivelesDisponibles = nivelAcutal;
        }
        PantallaMensaje();
    }

    public void DesbloquearNivelAtencion()
    {
        if (nivelesDisponiblesAtencion < nivelAcutalAtencion)
        {
            nivelesDisponiblesAtencion = nivelAcutalAtencion;
        }
        PantallaMensaje();
    }

    void RegresarMenu()
    {
        ActualizarNivelEmociones(0);
        ActualizarNivelAtencion(0);
    }

    public void ActualizarBotones()
    {
        try
        {
            for (int i = 0; i < nivelesDisponibles + 1; i++)
            {
                botonesMenuEmociones[i].interactable = true;
            }
        }
        catch (System.IndexOutOfRangeException)
        {
        }
    }

    public void ActualizarBotonesAtencion()
    {
        try
        {
            for (int i = 0; i < nivelesDisponiblesAtencion + 1; i++)
            {
                botonesMenuAtencion[i].interactable = true;
            }
        }
        catch (System.IndexOutOfRangeException)
        {
        }
    }
}
