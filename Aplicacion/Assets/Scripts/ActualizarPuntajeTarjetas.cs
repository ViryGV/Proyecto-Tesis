using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo que permite actualizar el número de errores 
/// y de aciertos de forma individual para las tarjetas
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

    public static int guardarEmocionesMax;
    public static int guardarEmocionesMin;
    public static int aciertosEmociones;

    public static int guardarAtencionMax;
    public static int guardarAtencionMin;
    public static int aciertosAtencion;

    public static int guardarMemoriaMax;
    public static int guardarMemoriaMin;
    public static int aciertosMemoria;

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
            textoGuardarEmocionesMax.text = PlayerPrefs.GetInt("PuntajeErrores", 0).ToString();
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
            textoGuardarEmocionesDosMax.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
            textoGuardarEmocionesDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0).ToString();
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
        else if (PlayerPrefs.GetInt("PuntajeErrores", 0) > PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0))
        {
            Debug.Log("Estoy en else if atencion");
            textoGuardarAtencionMax.enabled = true;
            textoGuardarAtencionIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMin", 0).ToString();
            textoGuardarAtencionMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencion", 0) != PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0))
        {
            Debug.Log("Estoy en else if actuales n1");
            textoGuardarAtencionMin.enabled = true;
            textoGuardarAtencionMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencion", 0).ToString();
            textoGuardarAtencionIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActuales", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores");
            textoGuardarAtencionMin.enabled = true;
            textoGuardarAtencionIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencion", 0).ToString();
            textoGuardarAtencionMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMin", 0).ToString();
        }
        textoAciertosAtencion.text = PlayerPrefs.GetInt("PuntajeAciertosEUno", 0).ToString();
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
            Debug.Log("Estoy en if actuales");

            textoGuardarAtencionDosMax.enabled = true;
            textoGuardarAtencionDosMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0).ToString();
            textoGuardarAtencionDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencionDos", 0) > PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0))
        {
            Debug.Log("Estoy en else if ");

            textoGuardarAtencionDosMax.enabled = true;
            textoGuardarAtencionDosMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0).ToString();
            textoGuardarAtencionDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0).ToString();
        }
        else if (PlayerPrefs.GetInt("PuntajeErroresAtencionDos", 0) != PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0))
        {
            Debug.Log("Estoy en else if actuales n2");
            textoGuardarAtencionDosMax.enabled = true;
            textoGuardarAtencionDosMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionDos", 0).ToString();
            textoGuardarAtencionDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresAtencionActualesDos", 0).ToString();
        }
        else
        {
            Debug.Log("Estoy en else if anteriores");

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
    }
}
