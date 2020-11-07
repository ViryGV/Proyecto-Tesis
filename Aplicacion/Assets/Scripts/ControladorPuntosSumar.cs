using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo del puntaje para superar un nivel de emociones
/// Además de activar y desactivar los componentes necesarios para superar el nivel
/// </summary>
public class ControladorPuntosSumar : MonoBehaviour
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
    /// <term>clarissa</term>
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
    /// <term>panelSiete</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelOcho</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// </list>
    /// </summary>
    public GameObject clarissa;
    public GameObject panelUno;
    public GameObject panelDos;
    public GameObject panelTres;
    public GameObject panelCuatro;
    public GameObject panelCinco;
    public GameObject panelSeis;
    public GameObject panelSiete;
    public GameObject panelOcho;

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

    /// <value>Permite al acceso de los datos de la clase</value>
    ControladorJuego controladorJuego;

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
    public void SumarPuntajeNivelUno()
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
            Debug.Log("puntaje 6");
            DesactivarPanelSeis();
            ActivarPanelSiete();
        }
        if (puntajeAciertos >= 7)
        {
            Debug.Log("puntaje 7");
            DesactivarPanelSiete();
            ActivarPanelOcho();
        }

        if (puntajeAciertos >= 8)
        {
            controladorJuego.DesbloquearNivelSumar();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosSUno", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosSUno", puntajeAciertos);
            }
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    /*public void SumarPuntajeNivelDos()
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
            DesactivarPanelAlegria();
            ActivarPanelEnojo();
        }
        if (puntajeAciertos >= 2)
        {
            Debug.Log("puntaje 2");
            DesactivarPanelEnojo();
            ActivarPanelTristeza();
        }
        if (puntajeAciertos >= 3)
        {
            Debug.Log("puntaje 3");
            DesactivarPanelTristeza();
            ActivarPanelSorpresa();
        }
        if (puntajeAciertos >= 4)
        {
            Debug.Log("puntaje 4");
            DesactivarPanelSorpresa();
            ActivarPanelTemor();
        }
        if (puntajeAciertos >= 5)
        {
            Debug.Log("puntaje 5");
            DesactivarPanelTemor();
            ActivarPanelAburrido();
        }
        if (puntajeAciertos >= 6)
        {
            Debug.Log("puntaje 6");
            DesactivarPanelAburrido();
            ActivarPanelPreocupado();
        }
        if (puntajeAciertos >= 7)
        {
            Debug.Log("puntaje 7");
            DesactivarPanelPreocupado();
            ActivarPanelCansado();
        }

        if (puntajeAciertos >= 8)
        {
            controladorJuego.DesbloquearNivel();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosSDos", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosSDos", puntajeAciertos);
            }
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntajeNivelTres()
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
            DesactivarPanelAlegria();
            ActivarPanelEnojo();
        }
        if (puntajeAciertos >= 2)
        {
            Debug.Log("puntaje 2");
            DesactivarPanelEnojo();
            ActivarPanelTristeza();
        }
        if (puntajeAciertos >= 3)
        {
            Debug.Log("puntaje 3");
            DesactivarPanelTristeza();
            ActivarPanelSorpresa();
        }
        if (puntajeAciertos >= 4)
        {
            Debug.Log("puntaje 4");
            DesactivarPanelSorpresa();
            ActivarPanelTemor();
        }
        if (puntajeAciertos >= 5)
        {
            Debug.Log("puntaje 5");
            DesactivarPanelTemor();
            ActivarPanelAburrido();
        }
        if (puntajeAciertos >= 6)
        {
            Debug.Log("puntaje 6");
            DesactivarPanelAburrido();
            ActivarPanelPreocupado();
        }
        if (puntajeAciertos >= 7)
        {
            Debug.Log("puntaje 7");
            DesactivarPanelPreocupado();
            ActivarPanelCansado();
        }

        if (puntajeAciertos >= 8)
        {
            controladorJuego.DesbloquearNivel();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosSTres", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosSTres", puntajeAciertos);
            }
        }
    }*/

    /// <summary>
    /// Método que va sumando las veces que el usuario se ha equivocado
    /// </summary>
    public void RestarPuntajeNivelUno()
    {
        puntajeErroresMax++;
        puntajeErroresMin++;
        puntajeErrores++;

        if ((puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresSumarActuales", 0)) &&
            (puntajeErrores > PlayerPrefs.GetInt("PuntajeErroresSumar", 0)))
        {
            Debug.Log("if n1");
            PlayerPrefs.SetInt("PuntajeErroresSumarActuales", puntajeErroresMax);
            PlayerPrefs.SetInt("PuntajeErroresMinSumar", puntajeErroresMin);
            Debug.Log("Errores Max n1 " + puntajeErroresMax);

        }
        else if ((puntajeErrores < PlayerPrefs.GetInt("PuntajeErroresSumarActuales", 0)) &&
          (puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresSumar", 0)))
        {
            Debug.Log("else if n1 " + puntajeErrores);
            PlayerPrefs.SetInt("PuntajeErroresSumar", puntajeErrores); //Actuales
            PlayerPrefs.SetInt("PuntajeErroresMinSumar", puntajeErroresMin);
            Debug.Log("Errores max en else if n1 " + puntajeErroresMax);
        }
        else
        {
            Debug.Log("else n1");
            PlayerPrefs.SetInt("PuntajeErroresSumarActuales", puntajeErroresMin);
            Debug.Log("Errores Min n1 " + puntajeErroresMin);
            Debug.Log("Errores Max n1 " + puntajeErroresMax);
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
        clarissa.SetActive(true);
        textoMensaje.text = "Bien Hecho";
    }

    /// <summary>
    /// Método que le indica al usuario que ha se equivocado
    /// </summary>
    public void ActivarPistas()
    {
        textoMensaje.enabled = true;
        clarissa.SetActive(true);
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
    }

    public void DesactivarPanelDos()
    {
        panelDos.SetActive(false);
    }

    public void ActivarPanelTres()
    {
        panelTres.SetActive(true);
    }

    public void DesactivarPanelTres()
    {
        panelTres.SetActive(false);
    }

    public void ActivarPanelCuatro()
    {
        panelCuatro.SetActive(true);
    }

    public void DesactivarPanelCuatro()
    {
        panelCuatro.SetActive(false);
    }

    public void ActivarPanelCinco()
    {
        panelCinco.SetActive(true);
    }

    public void DesactivarPanelCinco()
    {
        panelCinco.SetActive(false);
    }

    public void ActivarPanelSeis()
    {
        panelSeis.SetActive(true);
    }

    public void DesactivarPanelSeis()
    {
        panelSeis.SetActive(false);
    }

    public void ActivarPanelSiete()
    {
        panelSiete.SetActive(true);
    }

    public void DesactivarPanelSiete()
    {
        panelSiete.SetActive(false);
    }

    public void ActivarPanelOcho()
    {
        panelOcho.SetActive(true);
    }

    public void DesactivarPanelOcho()
    {
        panelOcho.SetActive(false);
    }
}
