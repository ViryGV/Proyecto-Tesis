﻿using System.Collections;
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
    public TextMeshProUGUI textoGuardarEmocionesDosIntermedio;
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

    //Historias
    public TextMeshProUGUI textoGuardarHistoriaMax;
    public TextMeshProUGUI textoGuardarHistoriaMin;
    public TextMeshProUGUI textoGuardarHistoriaDosMax;
    public TextMeshProUGUI textoGuardarHistoriaDosMin;
    public TextMeshProUGUI textoGuardarHistoriaTresMax;
    public TextMeshProUGUI textoGuardarHistoriaTresMin;
    public TextMeshProUGUI textoAciertosHistoria;
    public TextMeshProUGUI textoAciertosHistoriaDos;
    public TextMeshProUGUI textoAciertosHistoriaTres;

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

    public static int guardarHistoriaMax;
    public static int guardarHistoriaMin;
    public static int aciertosHistoria;

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
        textoGuardarEmocionesMin.text = PlayerPrefs.GetInt("PuntajeErroresMin", 0).ToString();
        textoGuardarEmocionesDosMax.text = PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0).ToString();
        textoGuardarEmocionesDosMin.text = PlayerPrefs.GetInt("PuntajeErroresDos", 0).ToString();
        textoGuardarEmocionesDosIntermedio.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
        textoGuardarEmocionesTresMax.text = PlayerPrefs.GetInt("PuntajeErroresMaxTres", 0).ToString();
        textoGuardarEmocionesTresMin.text = PlayerPrefs.GetInt("PuntajeErroresMinTres", 0).ToString();
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

        textoGuardarHistoriaMax.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMax", 0).ToString();
        textoGuardarHistoriaMin.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMin", 0).ToString();
        textoGuardarHistoriaDosMax.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMaxDos", 0).ToString();
        textoGuardarHistoriaDosMin.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMinDos", 0).ToString();
        textoGuardarHistoriaTresMax.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMaxTres", 0).ToString();
        textoGuardarHistoriaTresMin.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMinTres", 0).ToString();
        textoAciertosHistoria.text = PlayerPrefs.GetInt("PuntajeAciertosHistoriasUno", 0).ToString();
        textoAciertosHistoriaDos.text = PlayerPrefs.GetInt("PuntajeAciertosHistoriaDos", 0).ToString();
        textoAciertosHistoriaTres.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
    }

    /*public void MostrarPuntajeMatematicas()
    {
        
    }*/
}
