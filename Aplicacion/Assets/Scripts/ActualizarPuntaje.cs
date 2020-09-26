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

    public GameObject barraActividades;
    public GameObject barraHistorias;

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

    public void BorrarDatos()
    {
        PlayerPrefs.DeleteKey("PuntajeErroresMax");
        PlayerPrefs.DeleteKey("PuntajeErroresMin");
        PlayerPrefs.DeleteKey("PuntajeErrores");
        textoGuardarEmocionesMax.text = "0";
        textoGuardarEmocionesMin.text = "0";
        PlayerPrefs.DeleteKey("PuntajeErroresMaxDos");
        PlayerPrefs.DeleteKey("PuntajeErroresMinDos");
        PlayerPrefs.DeleteKey("PuntajeErrores");
        textoGuardarEmocionesDosMax.text = "0";
        textoGuardarEmocionesDosMin.text = "0";
        PlayerPrefs.DeleteKey("PuntajeErroresMaxTres");
        PlayerPrefs.DeleteKey("PuntajeErroresMinTres");
        PlayerPrefs.DeleteKey("PuntajeErrores");
        textoGuardarEmocionesTresMax.text = "0";
        textoGuardarEmocionesTresMin.text = "0";
        PlayerPrefs.DeleteKey("PuntajeAciertos");
        textoAciertosEmociones.text = "0";
        textoAciertosEmocionesDos.text = "0";
        textoAciertosEmocionesTres.text = "0";
    }
}
