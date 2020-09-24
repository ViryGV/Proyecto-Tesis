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

    public GameObject barra;

    public static int guardarEmocionesMax;
    public static int guardarEmocionesMin;
    public static int aciertosEmociones;

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
        barra.SetActive(true);
        textoGuardarEmocionesDosMax.text = PlayerPrefs.GetInt("PuntajeErroresMaxDos", 0).ToString();
        textoGuardarEmocionesDosMin.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
        textoGuardarEmocionesMax.text = PlayerPrefs.GetInt("PuntajeErroresMax", 0).ToString();
        textoGuardarEmocionesMin.text = PlayerPrefs.GetInt("PuntajeErroresMin", 0).ToString();
        textoGuardarEmocionesTresMax.text = PlayerPrefs.GetInt("PuntajeErroresMaxTres", 0).ToString();
        textoGuardarEmocionesTresMin.text = PlayerPrefs.GetInt("PuntajeErroresMinTres", 0).ToString();
        textoAciertosEmociones.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoAciertosEmocionesDos.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoAciertosEmocionesTres.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
    }

    /*public void MostrarPuntajeHistorias()
    {
        
    }

    public void MostrarPuntajeMatematicas()
    {
        
    }*/
}
