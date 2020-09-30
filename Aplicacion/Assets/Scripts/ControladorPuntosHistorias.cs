using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo del puntaje para superar un nivel de atención
/// Además de activar y desactivar los componentes necesarios para superar el nivel
/// </summary>
public class ControladorPuntosHistorias : MonoBehaviour
{
    /// <value>Establece el valor de los aciertos que será mostrado en pantalla</value>
    public TextMeshProUGUI textoAciertos;
    TextMeshProUGUI textoGuardarAciertos;
    /// <value>Establece el valor del texto que será mostrado en pantalla como una ayuda</value>
    public TextMeshProUGUI textoMensaje;
    public GameObject tobi;

    //Historia Uno (Respetar filas)
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el primer nivel</value>
    TextMeshProUGUI textoErrores;
    TextMeshProUGUI textoGuardar;
    TextMeshProUGUI textoErroresMax;
    TextMeshProUGUI textoGuardarMax;
    TextMeshProUGUI textoErroresMin;
    TextMeshProUGUI textoGuardarMin;

    //Historia Dos (Saludar)
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el segundo nivel</value>
    TextMeshProUGUI textoErroresDos;
    TextMeshProUGUI textoGuardarDos;
    TextMeshProUGUI textoErroresMaxDos;
    TextMeshProUGUI textoGuardarMaxDos;
    TextMeshProUGUI textoErroresMinDos;
    TextMeshProUGUI textoGuardarMinDos;

    //Historia Tres (Escuchar)
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el tercer nivel</value>
    TextMeshProUGUI textoErroresTres;
    TextMeshProUGUI textoGuardarTres;
    TextMeshProUGUI textoErroresMaxTres;
    TextMeshProUGUI textoGuardarMaxTres;
    TextMeshProUGUI textoErroresMinTres;
    TextMeshProUGUI textoGuardarMinTres;

    /// <value>Establece el valor estático (para guardar) intermedio
    /// de las veces que el usuario se ha equivocado</value>
    public static int puntajeErrores;
    /// <value>Establece el valor estático (para guardar) menor 
    /// de las veces que el usuario se ha equivocado
    /// </value>
    public static int puntajeErroresMin;
    /// <value>Establece el valor estático (para guardar) mayor 
    /// de las veces que el usuario se ha equivocado
    /// </value>
    public static int puntajeErroresMax;
    public static int puntajeErroresDos;
    public static int puntajeErroresMinDos;
    public static int puntajeErroresMaxDos;
    public static int puntajeErroresTres;
    public static int puntajeErroresMinTres;
    public static int puntajeErroresMaxTres;
    /// <value>Establece el valor estático de las veces que aciertas</value>
    public static int puntajeAciertos;
    public static int puntajeAciertosDos;

    PantallaMensajesHistorias mensajes;

    /// <summary>
    /// Inicializa las variables establecidas
    /// </summary>
    void Start()
    {
        puntajeErrores = 0;
        puntajeErroresMax = 0;
        puntajeErroresMin = 0;
        puntajeErroresDos = 0;
        puntajeErroresMaxDos = 0;
        puntajeErroresMinDos = 0;
        puntajeErroresTres = 0;
        puntajeErroresMaxTres = 0;
        puntajeErroresMinTres = 0;
        puntajeAciertos = 0;
        /*textoGuardar.text = PlayerPrefs.GetInt("PuntajeErroresHistorias", 0).ToString();
        textoGuardarMax.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMax", 0).ToString();
        textoGuardarMin.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMin", 0).ToString();
        textoGuardarDos.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasDos", 0).ToString();
        textoGuardarMaxDos.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMaxDos", 0).ToString();
        textoGuardarMinDos.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMinDos", 0).ToString();
        textoGuardarTres.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasTres", 0).ToString();
        textoGuardarMaxTres.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMaxTres", 0).ToString();
        textoGuardarMinTres.text = PlayerPrefs.GetInt("PuntajeErroresHistoriasMinTres", 0).ToString();
        textoGuardarAciertos.text = PlayerPrefs.GetInt("PuntajeAciertosHistoriasUno", 0).ToString();
        textoGuardarAciertos.text = PlayerPrefs.GetInt("PuntajeAciertosHistoriaDos", 0).ToString();*/
    }

    /// <summary>
    /// Permite encontrar y asegurar que existe la clase a la que se quiere acceder
    /// </summary>
    void Awake()
    {
        mensajes = GetComponent<PantallaMensajesHistorias>();
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntaje()
    {
        puntajeAciertos++;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 1)
        {
            PlayerPrefs.SetInt("PuntajeAciertosHistoriasUno", puntajeAciertos);
            PlayerPrefs.SetInt("PuntajeAciertosHistoriasDos", puntajeAciertosDos);
            mensajes.CargarPanelMensaje();
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario se ha equivocado
    /// </summary>
    public void RestarPuntajeHistoriaUno()
    {
        puntajeErrores++;
        puntajeErroresMin++;
        puntajeErroresMax++;

        if (puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresHistoriasMax", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasMax", puntajeErroresMax);
            PlayerPrefs.SetInt("PuntajeErroresHistoriasMin", puntajeErroresMax);
            Debug.Log("Errores Max " + puntajeErroresMax);

        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasMax", puntajeErroresMin);
            Debug.Log("Errores Min " + puntajeErroresMin);
            Debug.Log("Errores Min con max" + puntajeErroresMax);
        }
        /*if ((puntajeErroresMin < puntajeErroresMax) && (puntajeErroresMin <= PlayerPrefs.GetInt("PuntajeErroresHistoriasMin", 0)))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasMin", puntajeErroresMin);
            Debug.Log("Errores Min " + puntajeErroresMin);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresHistorias", puntajeErrores);
            Debug.Log("Errores Normal " + puntajeErrores);
        }*/

        if (puntajeErrores >= 3)
        {
            mensajes.CargarPanelMensajeEquivocado();
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeHistoriaDos()
    {
        puntajeErroresMaxDos++;
        puntajeErroresMinDos++;
        puntajeErroresDos++;

        if (puntajeErroresMaxDos > PlayerPrefs.GetInt("PuntajeErroresHistoriasMaxDos", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasMaxDos", puntajeErroresMaxDos);
            Debug.Log("Errores Max dos " + puntajeErroresMaxDos);
        }
        else if (puntajeErroresMinDos <= PlayerPrefs.GetInt("PuntajeErroresHistoriasMinDos", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasMinDos", puntajeErroresMinDos);
            Debug.Log("Errores Min dos " + puntajeErroresMinDos);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasDos", puntajeErroresDos);
            Debug.Log("Errores Normal dos " + puntajeErroresDos);
        }

        if (puntajeErrores >= 3)
        {
            mensajes.CargarPanelMensajeEquivocado();
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeHistoriaTres()
    {
        puntajeErroresMaxTres++;
        puntajeErroresMinTres++;
        puntajeErroresTres++;

        if (puntajeErroresMaxTres > PlayerPrefs.GetInt("PuntajeErroresHistoriasMaxTres", 0))
        {
            Debug.Log("if tres");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasMaxTres", puntajeErroresMaxTres);
            Debug.Log("Errores Max " + puntajeErroresMaxTres);
        }
        else if (puntajeErroresMinTres <= PlayerPrefs.GetInt("PuntajeErroresHistoriasMinTres", 0))
        {
            Debug.Log("elese if 3");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasMinTres", puntajeErroresMinTres);
            Debug.Log("Errores Min " + puntajeErroresMinTres);
        }
        else
        {
            Debug.Log("else 3");
            PlayerPrefs.SetInt("PuntajeErroresHistoriasTres", puntajeErroresTres);
            Debug.Log("Errores Normal " + puntajeErroresTres);
        }

        if (puntajeErrores >= 3)
        {
            mensajes.CargarPanelMensajeEquivocado();
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    /// <summary>
    /// Muestra en pantalla los puntos que el usuario va obteniendo
    /// </summary>
    void ActualizarTextoPuntaje()
    {
        textoAciertos.text = "Aciertos " + puntajeAciertos.ToString();
    }

    /// <summary>
    /// Método que le indica al usuario cuando acierta
    /// </summary>
    public void ActivarStatus()
    {
        textoMensaje.enabled = true;
        tobi.SetActive(true);
        textoMensaje.text = "Bien Hecho";
    }

    /// <summary>
    /// Método que le indica al usuario que ha se equivocado
    /// </summary>
    public void ActivarPistas()
    {
        textoMensaje.enabled = true;
        tobi.SetActive(true);
        textoMensaje.text = "Intentalo de nuevo";
    }
}
