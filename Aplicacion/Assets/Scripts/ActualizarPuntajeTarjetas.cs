﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo que permite actualizar el número de errores 
/// y de aciertos de forma individual para las tarjetas con sus respectivos
/// niveles
/// </summary>
public class ActualizarPuntajeTarjetas : MonoBehaviour
{
    public GameObject barraNivelUnoEmociones;
    public GameObject barraNivelDosEmociones;
    public GameObject barraNivelTresEmociones;

    public GameObject barraNivelUnoAtencion;
    public GameObject barraNivelDosAtencion;
    public GameObject barraNivelTresAtencion;

    public GameObject barraNivelUnoMemoria;
    public GameObject barraNivelDosMemoria;
    public GameObject barraNivelTresMemoria;

    public GameObject barraNivelUnoComedor;
    public GameObject barraNivelDosComedor;
    public GameObject barraNivelUnoUrbanidad;
    public GameObject barraNivelDosUrbanidad;
    public GameObject barraNivelUnoEscuela;
    public GameObject barraNivelDosEscuela;

    //Tarjeta Reconocimiento de Emociones
    public TextMeshProUGUI textoGuardarEmocionesMax;
    public TextMeshProUGUI textoGuardarEmocionesMin;
    public TextMeshProUGUI textoGuardarEmocionesIntermedio;
    public TextMeshProUGUI textoGuardarEmocionesDosMax;
    public TextMeshProUGUI textoGuardarEmocionesDosMin;
    public TextMeshProUGUI textoGuardarEmocionesDosIntermedio;
    public TextMeshProUGUI textoGuardarEmocionesTresMax;
    public TextMeshProUGUI textoGuardarEmocionesTresMin;
    public TextMeshProUGUI textoGuardarEmocionesTresIntermedio;
    public TextMeshProUGUI textoAciertosEmociones;
    public TextMeshProUGUI textoAciertosEmocionesDos;
    public TextMeshProUGUI textoAciertosEmocionesTres;

    //Tarjeta Atención
    public TextMeshProUGUI textoGuardarAtencionMax;
    public TextMeshProUGUI textoGuardarAtencionMin;
    public TextMeshProUGUI textoGuardarAtencionIntermedio;
    public TextMeshProUGUI textoGuardarAtencionDosMax;
    public TextMeshProUGUI textoGuardarAtencionDosMin;
    public TextMeshProUGUI textoGuardarAtencionDosIntermedio;
    public TextMeshProUGUI textoGuardarAtencionTresMax;
    public TextMeshProUGUI textoGuardarAtencionTresMin;
    public TextMeshProUGUI textoGuardarAtencionTresIntermedio;
    public TextMeshProUGUI textoAciertosAtencion;
    public TextMeshProUGUI textoAciertosAtencionDos;
    public TextMeshProUGUI textoAciertosAtencionTres;

    //Tarjeta Memoria de Trabajo
    public TextMeshProUGUI textoGuardarMemoriaMax;
    public TextMeshProUGUI textoGuardarMemoriaMin;
    public TextMeshProUGUI textoGuardarMemoriaIntermedio;
    public TextMeshProUGUI textoGuardarMemoriaDosMax;
    public TextMeshProUGUI textoGuardarMemoriaDosMin;
    public TextMeshProUGUI textoGuardarMemoriaDosIntermedio;
    public TextMeshProUGUI textoGuardarMemoriaTresMax;
    public TextMeshProUGUI textoGuardarMemoriaTresMin;
    public TextMeshProUGUI textoGuardarMemoriaTresIntermedio;
    public TextMeshProUGUI textoAciertosMemoria;
    public TextMeshProUGUI textoAciertosMemoriaDos;
    public TextMeshProUGUI textoAciertosMemoriaTres;

    //Tarjeta Instrucciones Visuales
    //Reglas del comedor
    public TextMeshProUGUI textoGuardarComedorMax;
    public TextMeshProUGUI textoGuardarComedorMin;
    public TextMeshProUGUI textoGuardarComedorIntermedio;
    public TextMeshProUGUI textoGuardarComedorDosMax;
    public TextMeshProUGUI textoGuardarComedorDosMin;
    public TextMeshProUGUI textoGuardarComedorDosIntermedio;
    public TextMeshProUGUI textoAciertosComedor;
    public TextMeshProUGUI textoAciertosComedorDos;

    //Reglas de urbanidad
    public TextMeshProUGUI textoGuardarUrbanidadMax;
    public TextMeshProUGUI textoGuardarUrbanidadMin;
    public TextMeshProUGUI textoGuardarUrbanidadIntermedio;
    public TextMeshProUGUI textoGuardarUrbanidadDosMax;
    public TextMeshProUGUI textoGuardarUrbanidadDosMin;
    public TextMeshProUGUI textoGuardarUrbanidadDosIntermedio;
    public TextMeshProUGUI textoAciertosUrbanidad;
    public TextMeshProUGUI textoAciertosUrbanidadDos;

    //Reglas del Salón de Clases
    public TextMeshProUGUI textoGuardarEscuelaMax;
    public TextMeshProUGUI textoGuardarEscuelaMin;
    public TextMeshProUGUI textoGuardarEscuelaIntermedio;
    public TextMeshProUGUI textoGuardarEscuelaDosMax;
    public TextMeshProUGUI textoGuardarEscuelaDosMin;
    public TextMeshProUGUI textoGuardarEscuelaDosIntermedio;
    public TextMeshProUGUI textoAciertosEscuela;
    public TextMeshProUGUI textoAciertosEscuelaDos;

    public static int guardarEmocionesMax;
    public static int guardarEmocionesMin;
    public static int aciertosEmociones;

    public static int guardarAtencionMax;
    public static int guardarAtencionMin;
    public static int aciertosAtencion;

    public static int guardarMemoriaMax;
    public static int guardarMemoriaMin;
    public static int aciertosMemoria;

    public static int guardarComedorMax;
    public static int guardarComedorMin;
    public static int aciertosComedor;
    public static int guardarUrbanidadMax;
    public static int guardarUrbanidadMin;
    public static int aciertosUrbanidad;
    public static int guardarEscuelaMax;
    public static int guardarEscuelaMin;
    public static int aciertosEscuela;

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel uno de reconocimiento de emociones
    /// </summary>
    public void MostrarPuntajeNivelUnoEmociones()
    {
        barraNivelUnoEmociones.SetActive(true);
        barraNivelDosEmociones.SetActive(false);
        barraNivelTresEmociones.SetActive(false);
        textoGuardarEmocionesMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresActuales", 0) == PlayerPrefs.GetInt("PuntajeErroresMin", 0))
        {
            Debug.Log("Estoy en if actuales");
            textoGuardarEmocionesMax.enabled = true;
            textoGuardarEmocionesMax.text = PlayerPrefs.GetInt("PuntajeErroresActuales", 0).ToString();
            textoGuardarEmocionesIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMin", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErrores", 0) > PlayerPrefs.GetInt("PuntajeErroresActuales", 0))
        {
            Debug.Log("Estoy en else if ");
            textoGuardarEmocionesMax.enabled = true;
            textoGuardarEmocionesIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMin", 0).ToString();
            textoGuardarEmocionesMax.text = PlayerPrefs.GetInt("PuntajeErroresActuales", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErrores", 0) != PlayerPrefs.GetInt("PuntajeActuales", 0))
        {
            Debug.Log("Estoy en else if actuales n1");
            textoGuardarEmocionesMin.enabled = true;
            textoGuardarEmocionesMin.text = PlayerPrefs.GetInt("PuntajeErrores", 0).ToString();
            textoGuardarEmocionesIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresActuales", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores");
            textoGuardarEmocionesMin.enabled = true;
            textoGuardarEmocionesIntermedio.text = PlayerPrefs.GetInt("PuntajeErrores", 0).ToString();
            textoGuardarEmocionesMin.text = PlayerPrefs.GetInt("PuntajeErroresMin", 0).ToString();
        }
        textoAciertosEmociones.text = PlayerPrefs.GetInt("PuntajeAciertosEUno", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel dos de reconocimiento de emociones
    /// </summary>
    public void MostrarPuntajeNivelDosEmociones()
    {
        barraNivelUnoEmociones.SetActive(false);
        barraNivelDosEmociones.SetActive(true);
        barraNivelTresEmociones.SetActive(false);
        textoGuardarEmocionesDosMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0) == PlayerPrefs.GetInt("PuntajeErroresMinDos", 0))
        {
            Debug.Log("Estoy en if actuales");

            textoGuardarEmocionesDosMax.enabled = true;
            textoGuardarEmocionesDosMax.text = PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0).ToString();
            textoGuardarEmocionesDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresDos", 0) > PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0))
        {
            Debug.Log("Estoy en else if ");

            textoGuardarEmocionesDosMax.enabled = true;
            textoGuardarEmocionesDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
            textoGuardarEmocionesDosMax.text = PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresDos", 0) != PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0))
        {
            Debug.Log("Estoy en else if actuales n2");
            textoGuardarEmocionesDosMax.enabled = true;
            //textoGuardarEmocionesDosMin.enabled = true;
            textoGuardarEmocionesDosMax.text = PlayerPrefs.GetInt("PuntajeErroresDos", 0).ToString();
            textoGuardarEmocionesDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0).ToString();
            //textoGuardarEmocionesDosMin.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores");

            textoGuardarEmocionesDosMin.enabled = true;
            textoGuardarEmocionesDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresDos", 0).ToString();
            textoGuardarEmocionesDosMin.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
        }
        textoAciertosEmocionesDos.text = PlayerPrefs.GetInt("PuntajeAciertosEDos", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel tres de reconocimiento de emociones
    /// </summary>
    public void MostrarPuntajeNivelTresEmociones()
    {
        barraNivelUnoEmociones.SetActive(false);
        barraNivelDosEmociones.SetActive(false);
        barraNivelTresEmociones.SetActive(true);
        textoGuardarEmocionesTresMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresActualesTres", 0) == PlayerPrefs.GetInt("PuntajeErroresMinTres", 0))
        {
            Debug.Log("Estoy en if actuales");
            textoGuardarEmocionesTresMax.enabled = true;
            textoGuardarEmocionesTresMax.text = PlayerPrefs.GetInt("PuntajeErroresActualesTres", 0).ToString();
            textoGuardarEmocionesTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMinTres", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresTres", 0) > PlayerPrefs.GetInt("PuntajeErroresActualesTres", 0))
        {
            Debug.Log("Estoy en else if ");
            textoGuardarEmocionesTresMax.enabled = true;
            textoGuardarEmocionesTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMinTres", 0).ToString();
            textoGuardarEmocionesTresMax.text = PlayerPrefs.GetInt("PuntajeErroresActualesTres", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresTres", 0) != PlayerPrefs.GetInt("PuntajeErroresActualesTres", 0))
        {
            textoGuardarEmocionesTresMax.enabled = true;
            textoGuardarEmocionesTresMax.text = PlayerPrefs.GetInt("PuntajeErroresTres", 0).ToString();
            textoGuardarEmocionesTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresActualesTres", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores");
            textoGuardarEmocionesTresMin.enabled = true;
            textoGuardarEmocionesTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresTres", 0).ToString();
            textoGuardarEmocionesTresMin.text = PlayerPrefs.GetInt("PuntajeErroresMinTres", 0).ToString();
        }

        textoAciertosEmocionesTres.text = PlayerPrefs.GetInt("PuntajeAciertosETres", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel uno de atención
    /// </summary>
    public void MostrarPuntajeNivelUnoAtencion()
    {
        barraNivelUnoAtencion.SetActive(true);
        barraNivelDosAtencion.SetActive(false);
        barraNivelTresAtencion.SetActive(false);
        textoGuardarAtencionMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0) == PlayerPrefs.GetInt("PuntajeErroresAtencionMin", 0))
        {
            Debug.Log("Estoy en if actuales atencion");
            textoGuardarAtencionMax.enabled = true;
            textoGuardarAtencionMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0).ToString();
            textoGuardarAtencionIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMin", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencion", 0) > PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0))
        {
            Debug.Log("Estoy en else if atencion");
            textoGuardarAtencionMax.enabled = true;
            textoGuardarAtencionIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMin", 0).ToString();
            textoGuardarAtencionMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencion", 0) != PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0))
        {
            Debug.Log("Estoy en else if actuales atencion n1");
            textoGuardarAtencionMin.enabled = true;
            textoGuardarAtencionMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencion", 0).ToString();
            textoGuardarAtencionIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores");
            textoGuardarAtencionMin.enabled = true;
            textoGuardarAtencionIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencion", 0).ToString();
            textoGuardarAtencionMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMin", 0).ToString();
        }
        textoAciertosAtencion.text = PlayerPrefs.GetInt("PuntajeAciertosAUno", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel dos de atención
    /// </summary>
    public void MostrarPuntajeNivelDosAtencion()
    {
        barraNivelUnoAtencion.SetActive(false);
        barraNivelDosAtencion.SetActive(true);
        barraNivelTresAtencion.SetActive(false);
        textoGuardarAtencionDosMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0) == PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0))
        {
            Debug.Log("Estoy en if actuales atencion n2");

            textoGuardarAtencionDosMax.enabled = true;
            textoGuardarAtencionDosMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0).ToString();
            textoGuardarAtencionDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencionDos", 0) > PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0))
        {
            Debug.Log("Estoy en else if atencion n2");

            textoGuardarAtencionDosMax.enabled = true;
            textoGuardarAtencionDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0).ToString();
            textoGuardarAtencionDosMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencionDos", 0) != PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0))
        {
            Debug.Log("Estoy en else if actuales atencion n2");
            textoGuardarAtencionDosMax.enabled = true;
            textoGuardarAtencionDosMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionDos", 0).ToString();
            textoGuardarAtencionDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores atencion n2");

            textoGuardarAtencionDosMin.enabled = true;
            textoGuardarAtencionDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionDos", 0).ToString();
            textoGuardarAtencionDosMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0).ToString();
        }
        textoAciertosAtencionDos.text = PlayerPrefs.GetInt("PuntajeAciertosADos", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel tres de atención
    /// </summary>
    public void MostrarPuntajeNivelTresAtencion()
    {
        barraNivelUnoAtencion.SetActive(false);
        barraNivelDosAtencion.SetActive(false);
        barraNivelTresAtencion.SetActive(true);
        textoGuardarAtencionTresMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresAtencionActualesTres", 0) == PlayerPrefs.GetInt("PuntajeErroresAtencionMinTres", 0))
        {
            Debug.Log("Estoy en if actuales");
            textoGuardarAtencionTresMax.enabled = true;
            textoGuardarAtencionTresMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesTres", 0).ToString();
            textoGuardarAtencionTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinTres", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencionTres", 0) > PlayerPrefs.GetInt("PuntajeErroresAtencionActualesTres", 0))
        {
            Debug.Log("Estoy en else if ");
            textoGuardarAtencionTresMax.enabled = true;
            textoGuardarAtencionTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinTres", 0).ToString();
            textoGuardarAtencionTresMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesTres", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencionTres", 0) != PlayerPrefs.GetInt("PuntajeErroresAtencionActualesTres", 0))
        {
            textoGuardarAtencionTresMax.enabled = true;
            textoGuardarAtencionTresMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionTres", 0).ToString();
            textoGuardarAtencionTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesTres", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores");
            textoGuardarAtencionTresMin.enabled = true;
            textoGuardarAtencionTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionTres", 0).ToString();
            textoGuardarAtencionTresMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinTres", 0).ToString();
        }

        textoAciertosAtencionTres.text = PlayerPrefs.GetInt("PuntajeAciertosATres", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel uno de memoria de trabajo
    /// </summary>
    public void MostrarPuntajeNivelUnoMemoria()
    {
        barraNivelUnoMemoria.SetActive(true);
        barraNivelDosMemoria.SetActive(false);
        barraNivelTresMemoria.SetActive(false);
        textoGuardarMemoriaMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresMemoriaActuales", 0) == PlayerPrefs.GetInt("PuntajeErroresMemoriaMin", 0))
        {
            Debug.Log("Estoy en if actuales memoria n1");
            textoGuardarMemoriaMax.enabled = true;
            textoGuardarMemoriaMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActuales", 0).ToString();
            textoGuardarMemoriaIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMin", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresMemoria", 0) > PlayerPrefs.GetInt("PuntajeErroresMemoriaActuales", 0))
        {
            Debug.Log("Estoy en else if memoria n1");
            textoGuardarMemoriaMax.enabled = true;
            textoGuardarMemoriaIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMin", 0).ToString();
            textoGuardarMemoriaMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActuales", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresMemoria", 0) != PlayerPrefs.GetInt("PuntajeErroresMemoriaActuales", 0))
        {
            Debug.Log("Estoy en else if actuales n1");
            textoGuardarMemoriaMin.enabled = true;
            textoGuardarMemoriaMax.enabled = false;
            textoGuardarMemoriaMin.text = PlayerPrefs.GetInt("PuntajeErroresMemoria", 0).ToString();
            textoGuardarMemoriaIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActuales", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores memoria n1");
            textoGuardarMemoriaMin.enabled = true;
            textoGuardarMemoriaIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoria", 0).ToString();
            textoGuardarMemoriaMin.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMin", 0).ToString();
        }
        textoAciertosMemoria.text = PlayerPrefs.GetInt("PuntajeAciertosMUno", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel dos de memoria de trabajo
    /// </summary>
    public void MostrarPuntajeNivelDosMemoria()
    {
        barraNivelUnoMemoria.SetActive(false);
        barraNivelDosMemoria.SetActive(true);
        barraNivelTresMemoria.SetActive(false);
        textoGuardarMemoriaDosMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesDos", 0) == PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0))
        {
            Debug.Log("Estoy en if actuales atencion");
            textoGuardarMemoriaDosMax.enabled = true;
            textoGuardarMemoriaDosMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesDos", 0).ToString();
            textoGuardarMemoriaDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresMemoriaDos", 0) > PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesDos", 0))
        {
            Debug.Log("Estoy en else if atencion");
            textoGuardarMemoriaDosMax.enabled = true;
            textoGuardarMemoriaDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0).ToString();
            textoGuardarMemoriaDosMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesDos", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresMemoriaDos", 0) != PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesDos", 0))
        {
            Debug.Log("Estoy en else if actuales n1");
            textoGuardarMemoriaDosMin.enabled = true;
            textoGuardarMemoriaDosMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaDos", 0).ToString();
            textoGuardarMemoriaDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesDos", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores");
            textoGuardarMemoriaDosMin.enabled = true;
            textoGuardarMemoriaDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaDos", 0).ToString();
            textoGuardarMemoriaDosMin.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0).ToString();
        }
        textoAciertosMemoriaDos.text = PlayerPrefs.GetInt("PuntajeAciertosMDos", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel tres de memoria de trabajo
    /// </summary>
    public void MostrarPuntajeNivelTresMemoria()
    {
        barraNivelUnoMemoria.SetActive(false);
        barraNivelDosMemoria.SetActive(false);
        barraNivelTresMemoria.SetActive(true);
        textoGuardarMemoriaTresMin.enabled = false;

        if (PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesTres", 0) == PlayerPrefs.GetInt("PuntajeErroresMemoriaMinTres", 0))
        {
            Debug.Log("Estoy en if actuales memoria n3");
            textoGuardarMemoriaTresMax.enabled = true;
            textoGuardarMemoriaTresMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesTres", 0).ToString();
            textoGuardarMemoriaTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinTres", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresMemoriaTres", 0) > PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesTres", 0))
        {
            Debug.Log("Estoy en else if memoria n3");
            textoGuardarMemoriaTresMax.enabled = true;
            textoGuardarMemoriaTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinTres", 0).ToString();
            textoGuardarMemoriaTresMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesTres", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresMemoriaTres", 0) != PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesTres", 0))
        {
            Debug.Log("Estoy en else if actuales memoria n3");
            textoGuardarMemoriaTresMin.enabled = true;
            textoGuardarMemoriaTresMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaTres", 0).ToString();
            textoGuardarMemoriaTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesTres", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores memoria n3");
            textoGuardarMemoriaTresMin.enabled = true;
            textoGuardarMemoriaTresIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaTres", 0).ToString();
            textoGuardarMemoriaTresMin.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinTres", 0).ToString();
        }
        textoAciertosMemoriaTres.text = PlayerPrefs.GetInt("PuntajeAciertosMTres", 0).ToString();
    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel uno de reglas del comedor
    /// </summary>
    public void MostrarPuntajeComedorNivelUno()
    {
        barraNivelUnoComedor.SetActive(true);
        barraNivelDosComedor.SetActive(false);
        barraNivelUnoUrbanidad.SetActive(false);
        barraNivelDosUrbanidad.SetActive(false);
        barraNivelUnoEscuela.SetActive(false);
        barraNivelDosEscuela.SetActive(false);
        textoGuardarComedorMin.enabled = false;

    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel dos de reglas del comedor
    /// </summary>
    public void MostrarPuntajeComedorNivelDos()
    {
        barraNivelUnoComedor.SetActive(false);
        barraNivelDosComedor.SetActive(true);
        barraNivelUnoUrbanidad.SetActive(false);
        barraNivelDosUrbanidad.SetActive(false);
        barraNivelUnoEscuela.SetActive(false);
        barraNivelDosEscuela.SetActive(false);
        textoGuardarComedorDosMin.enabled = false;

    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel uno de reglas de Urbanidad
    /// </summary>
    public void MostrarPuntajeUrbanidadNivelUno()
    {
        barraNivelUnoUrbanidad.SetActive(true);
        barraNivelDosUrbanidad.SetActive(false);
        barraNivelUnoComedor.SetActive(false);
        barraNivelDosComedor.SetActive(false);
        barraNivelUnoEscuela.SetActive(false);
        barraNivelDosEscuela.SetActive(false);
        textoGuardarUrbanidadMin.enabled = false;

    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel dos de reglas de urbanidad
    /// </summary>
    public void MostrarPuntajeUrbanidadNivelDos()
    {
        barraNivelUnoUrbanidad.SetActive(false);
        barraNivelDosUrbanidad.SetActive(true);
        barraNivelUnoComedor.SetActive(false);
        barraNivelDosComedor.SetActive(false);
        barraNivelUnoEscuela.SetActive(false);
        barraNivelDosEscuela.SetActive(false);
        textoGuardarUrbanidadDosMin.enabled = false;

    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel uno de reglas del salón de clases
    /// </summary>
    public void MostrarPuntajeEscuelaNivelUno()
    {
        barraNivelUnoEscuela.SetActive(true);
        barraNivelDosEscuela.SetActive(false);
        barraNivelUnoUrbanidad.SetActive(false);
        barraNivelDosUrbanidad.SetActive(false);
        barraNivelUnoComedor.SetActive(false);
        barraNivelDosComedor.SetActive(false);
        barraNivelUnoEscuela.SetActive(false);
        barraNivelDosEscuela.SetActive(false);
        textoGuardarEscuelaMin.enabled = false;

    }

    /// <summary>
    /// Método que se encarga de mostrar el número de errores y aciertos
    /// que se obtuvieron al entrar al nivel dos de reglas del salón de clases
    /// </summary>
    public void MostrarPuntajeEscuelaNivelDos()
    {
        barraNivelUnoEscuela.SetActive(false);
        barraNivelDosEscuela.SetActive(true);
        barraNivelUnoUrbanidad.SetActive(false);
        barraNivelDosUrbanidad.SetActive(false);
        barraNivelUnoComedor.SetActive(false);
        barraNivelDosComedor.SetActive(false);
        textoGuardarEscuelaDosMin.enabled = false;

    }
}
