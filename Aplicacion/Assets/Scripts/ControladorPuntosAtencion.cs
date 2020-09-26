using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo del puntaje para superar un nivel de atención
/// Además de activar y desactivar los componentes necesarios para superar el nivel
/// </summary>
public class ControladorPuntosAtencion : MonoBehaviour
{
    /// <value>Establece el valor de los aciertos que será mostrado en pantalla</value>
    public TextMeshProUGUI textoAciertos;
    TextMeshProUGUI textoGuardarAciertos;
    /// <value>Establece el valor del texto que será mostrado en pantalla como una ayuda</value>
    public TextMeshProUGUI textoMensaje;

    //Nivel Uno
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el primer nivel</value>
    TextMeshProUGUI textoErrores;
    TextMeshProUGUI textoGuardar;
    TextMeshProUGUI textoErroresMax;
    TextMeshProUGUI textoGuardarMax;
    TextMeshProUGUI textoErroresMin;
    TextMeshProUGUI textoGuardarMin;

    //Nivel Dos
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el segundo nivel</value>
    TextMeshProUGUI textoErroresDos;
    TextMeshProUGUI textoGuardarDos;
    TextMeshProUGUI textoErroresMaxDos;
    TextMeshProUGUI textoGuardarMaxDos;
    TextMeshProUGUI textoErroresMinDos;
    TextMeshProUGUI textoGuardarMinDos;

    //Nivel Tres
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el tercer nivel</value>
    TextMeshProUGUI textoErroresTres;
    TextMeshProUGUI textoGuardarTres;
    TextMeshProUGUI textoErroresMaxTres;
    TextMeshProUGUI textoGuardarMaxTres;
    TextMeshProUGUI textoErroresMinTres;
    TextMeshProUGUI textoGuardarMinTres;

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
    /// <term>panelCinco</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelSeis</term>
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
    /// <item>
    /// <term>objetoCuatro</term>
    /// <description>Es un elemento que contiene el sprite (imagen) del objeto</description>
    /// </item>
    /// <item>
    /// <term>objetoCinco</term>
    /// <description>Es un elemento que contiene el sprite (imagen) del objeto</description>
    /// </item>
    /// <item>
    /// <term>objetoSeis</term>
    /// <description>Es un elemento que contiene el sprite (imagen) del objeto</description>
    /// </item>
    /// <item>
    /// <term>objetoSiete</term>
    /// <description>Es un elemento que contiene el sprite (imagen) del objeto</description>
    /// </item>
    /// </list>
    /// </summary>
    public GameObject cosmo;
    public GameObject panelUno;
    public GameObject panelDos;
    public GameObject panelTres;
    public GameObject panelCuatro;
    public GameObject panelCinco;
    public GameObject panelSeis;
    public GameObject objetoUno;
    public GameObject objetoDos;
    public GameObject objetoTres;
    public GameObject objetoCuatro;
    public GameObject objetoCinco;
    public GameObject objetoSeis;

    /// <value>Establece el valor de las veces que aciertas</value>
    public static int puntajeAciertos;
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

    /// <value>Permite al acceso de los datos de la clase</value>
    ControladorJuego controladorJuego;

    /// <value>Acceder al valor de Renderer en los objetos para manipularlos</value>
    Renderer renderUno;
    Renderer renderDos;
    Renderer renderTres;
    Renderer renderCuatro;
    Renderer renderCinco;
    Renderer renderSeis;

    /// <summary>
    /// Inicializa las variables establecidas
    /// </summary>
    void Start()
    {
        renderUno = objetoUno.GetComponent<Renderer>();
        renderDos = objetoDos.GetComponent<Renderer>();
        renderTres = objetoTres.GetComponent<Renderer>();
        renderCuatro = objetoCuatro.GetComponent<Renderer>();
        renderCinco = objetoCinco.GetComponent<Renderer>();
        renderSeis = objetoSeis.GetComponent<Renderer>();
        puntajeErrores = 0;
        puntajeErroresMax = 0;
        puntajeErroresMin = 0;
        puntajeErroresDos = 0;
        puntajeErroresMaxDos = 0;
        puntajeErroresMinDos = 0;
        puntajeAciertos = 0;
        textoGuardar.text = PlayerPrefs.GetInt("PuntajeErroresAtencion", 0).ToString();
        textoGuardarMax.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMax", 0).ToString();
        textoGuardarMin.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMin", 0).ToString();
        textoGuardarDos.text = PlayerPrefs.GetInt("PuntajeErroresAtencionDos", 0).ToString();
        textoGuardarMaxDos.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMaxDos", 0).ToString();
        textoGuardarMinDos.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0).ToString();
        textoGuardarTres.text = PlayerPrefs.GetInt("PuntajeErroresAtencionTres", 0).ToString();
        textoGuardarMaxTres.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMaxTres", 0).ToString();
        textoGuardarMinTres.text = PlayerPrefs.GetInt("PuntajeErroresAtencionMinTres", 0).ToString();
        textoGuardarAciertos.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
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
            ActivarPanelDos();
        }
        if (puntajeAciertos >= 2)
        {
            Debug.Log("puntaje 2");
            DesactivarPanelDos();
            ActivarPanelTres();
        }
        if (puntajeAciertos >= 3)
        {
            Debug.Log("puntaje 3");
            DesactivarPanelTres();
            ActivarPanelCuatro();
        }
        if (puntajeAciertos >= 4)
        {
            Debug.Log("puntaje 4");
            DesactivarPanelCuatro();
            ActivarPanelCinco();
        }
        if (puntajeAciertos >= 5)
        {
            Debug.Log("puntaje 5");
            DesactivarPanelCinco();
            ActivarPanelSeis();
        }
        if (puntajeAciertos >= 6)
        {
            controladorJuego.DesbloquearNivelAtencion();
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario se ha equivocado
    /// </summary>
    public void RestarPuntajeNivelUno()
    {
        puntajeErroresMax++;
        puntajeErroresMin++;
        puntajeErrores++;

        if (puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresAtencionMax", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresAtencionMax", puntajeErroresMax);
            Debug.Log("Errores Max " + puntajeErroresMax);
        }
        else if (puntajeErroresMin <= PlayerPrefs.GetInt("PuntajeErroresAtencionMin", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresAtencionMin", puntajeErroresMin);
            Debug.Log("Errores Min " + puntajeErroresMin);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresAtencion", puntajeErrores);
            Debug.Log("Errores Normal " + puntajeErrores);
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeNivelDos()
    {
        puntajeErroresMaxDos++;
        puntajeErroresMinDos++;
        puntajeErroresDos++;

        if (puntajeErroresMaxDos > PlayerPrefs.GetInt("PuntajeErroresAtencionMaxDos", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresAtencionMaxDos", puntajeErroresMaxDos);
            Debug.Log("Errores Max dos " + puntajeErroresMaxDos);
        }
        else if (puntajeErroresMin <= PlayerPrefs.GetInt("PuntajeErroresAtencionMinDos", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresAtencionMinDos", puntajeErroresMinDos);
            Debug.Log("Errores Min dos " + puntajeErroresMinDos);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresAtencionDos", puntajeErroresDos);
            Debug.Log("Errores Normal dos " + puntajeErroresDos);
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeNivelTres()
    {
        puntajeErroresMaxTres++;
        puntajeErroresMinTres++;
        puntajeErroresTres++;

        if (puntajeErroresMaxTres > PlayerPrefs.GetInt("PuntajeErroresAtencionMaxTres", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresAtencionMaxTres", puntajeErroresMaxTres);
            Debug.Log("Errores Max 3 " + puntajeErroresMaxTres);
        }
        else if (puntajeErroresMinTres <= PlayerPrefs.GetInt("PuntajeErroresAtencionMinTres", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresAtencionMinTres", puntajeErroresMinTres);
            Debug.Log("Errores Min 3 " + puntajeErroresMinTres);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresAtencionTres", puntajeErroresTres);
            Debug.Log("Errores Normal 3 " + puntajeErroresTres);
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
    }

    public void DesactivarPanelUno()
    {
        panelUno.SetActive(false);
    }

    public void ActivarPanelDos()
    {
        panelDos.SetActive(true);
        renderUno.enabled = true;
        renderDos.enabled = true;
    }

    public void DesactivarPanelDos()
    {
        panelDos.SetActive(false);
        renderDos.enabled = false;
    }

    public void ActivarPanelTres()
    {
        panelTres.SetActive(true);
        renderTres.enabled = true;
    }

    public void DesactivarPanelTres()
    {
        panelTres.SetActive(false);
        renderTres.enabled = false;
    }

    public void ActivarPanelCuatro()
    {
        panelCuatro.SetActive(true);
        renderCuatro.enabled = true;
    }

    public void DesactivarPanelCuatro()
    {
        panelCuatro.SetActive(false);
        renderCuatro.enabled = false;
    }

    public void ActivarPanelCinco()
    {
        panelCinco.SetActive(true);
        renderCinco.enabled = true;
    }

    public void DesactivarPanelCinco()
    {
        panelCinco.SetActive(false);
        renderCinco.enabled = false;
    }

    public void ActivarPanelSeis()
    {
        panelSeis.SetActive(true);
        renderSeis.enabled = true;
    }

    public void DesactivarPanelSeis()
    {
        panelSeis.SetActive(false);
        renderSeis.enabled = false;
    }
}