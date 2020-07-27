using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ControladorJuego : MonoBehaviour
{
    static public int nivelesDisponibles;

    public int nivelAcutal;

    public Button[] botonesMenuEmociones;

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
            cargar_guardar.Guardar();
            ActualizarBotones();
        }
    }

    public void ActualizarNivel(int nivel)
    {
        if (nivel == 0)
        {
            SceneManager.LoadScene("NivelesEmociones");
        }
        else
        {
            SceneManager.LoadScene("EmocionesNivel" + nivel);
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

    void RegresarMenu()
    {
        ActualizarNivel(0);
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
}
