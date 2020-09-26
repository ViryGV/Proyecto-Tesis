using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//compile with: -doc:DocFileName.xml

public class ActualizarPuntaje : MonoBehaviour
{
    //Tarjeta Reconocimiento de Emociones
    public TextMeshProUGUI textoGuardarEmocionesMax;
    public TextMeshProUGUI textoGuardarEmocionesMin;
    public TextMeshProUGUI textoGuardarEmocionesDosMax;
    public TextMeshProUGUI textoGuardarEmocionesDosMin;
    public TextMeshProUGUI textoGuardarEmocionesTresMax;
    public TextMeshProUGUI textoGuardarEmocionesTresMin;
    public TextMeshProUGUI textoAciertosEmociones;
    public TextMeshProUGUI textoAciertosEmocionesDos;
    public TextMeshProUGUI textoAciertosEmocionesTres;

    //Tarjeta Atención
    public TextMeshProUGUI textoGuardarAtencionMax;
    public TextMeshProUGUI textoGuardarAtencionMin;
    public TextMeshProUGUI textoGuardarAtencionDosMax;
    public TextMeshProUGUI textoGuardarAtencionDosMin;
    public TextMeshProUGUI textoGuardarAtencionTresMax;
    public TextMeshProUGUI textoGuardarAtencionTresMin;
    public TextMeshProUGUI textoAciertosAtencion;
    public TextMeshProUGUI textoAciertosAtencionDos;
    public TextMeshProUGUI textoAciertosAtencionTres;

    //Tarjeta Memoria de Trabajo
    public TextMeshProUGUI textoGuardarMemoriaMax;
    public TextMeshProUGUI textoGuardarMemoriaMin;
    public TextMeshProUGUI textoGuardarMemoriaDosMax;
    public TextMeshProUGUI textoGuardarMemoriaDosMin;
    public TextMeshProUGUI textoGuardarMemoriaTresMax;
    public TextMeshProUGUI textoGuardarMemoriaTresMin;
    public TextMeshProUGUI textoAciertosMemoria;
    public TextMeshProUGUI textoAciertosMemoriaDos;
    public TextMeshProUGUI textoAciertosMemoriaTres;


    public GameObject barraActividades;
    public GameObject barraHistorias;

    public static int guardarEmocionesMax;
    public static int guardarEmocionesMin;
    public static int aciertosEmociones;

    public static int guardarAtencionMax;
    public static int guardarAtencionMin;
    public static int aciertosAtencion;

    public static int guardarMemoriaMax;
    public static int guardarMemoriaMin;
    public static int aciertosMemoria;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void MostrarPuntajeActividades()
    {
        Debug.Log("Entre");
        barraActividades.SetActive(true);
        barraHistorias.SetActive(false);
        textoGuardarEmocionesMax.text = PlayerPrefs.GetInt("PuntajeErroresMax", 0).ToString();
        textoGuardarEmocionesMin.text = PlayerPrefs.GetInt("PuntajeErrores", 0).ToString();
        textoGuardarEmocionesDosMax.text = PlayerPrefs.GetInt("PuntajeErroresMaxDos", 0).ToString();
        textoGuardarEmocionesDosMin.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
        textoGuardarEmocionesTresMax.text = PlayerPrefs.GetInt("PuntajeErroresMaxTres", 0).ToString();
        textoGuardarEmocionesTresMin.text = PlayerPrefs.GetInt("PuntajeErroresTres", 0).ToString();
        textoAciertosEmociones.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoAciertosEmocionesDos.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoAciertosEmocionesTres.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        //Atencion
        textoGuardarAtencionMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMax", 0).ToString();
        textoGuardarAtencionMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencion", 0).ToString();
        textoGuardarAtencionDosMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMaxDos", 0).ToString();
        textoGuardarAtencionDosMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0).ToString();
        textoGuardarAtencionTresMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMaxTres", 0).ToString();
        textoGuardarAtencionTresMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencionTres", 0).ToString();
        textoAciertosAtencion.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoAciertosAtencionDos.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoAciertosAtencionTres.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        //Memoria
        textoGuardarMemoriaMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMax", 0).ToString();
        textoGuardarMemoriaMin.text = PlayerPrefs.GetInt("PuntajeErroresMemoria", 0).ToString();
        textoGuardarMemoriaDosMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMaxDos", 0).ToString();
        textoGuardarMemoriaDosMin.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0).ToString();
        textoGuardarMemoriaTresMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMaxTres", 0).ToString();
        textoGuardarMemoriaTresMin.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaTres", 0).ToString();
        textoAciertosMemoria.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoAciertosMemoriaDos.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoAciertosMemoriaTres.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
    }

    public void MostrarPuntajeHistorias()
    {
        Debug.Log("Entre");
        barraHistorias.SetActive(true);
        barraActividades.SetActive(false);
    }

    /*public void MostrarPuntajeMatematicas()
    {
        
    }*/
}
