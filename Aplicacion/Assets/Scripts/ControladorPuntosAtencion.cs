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
    //public Text textoErrores;
    /// <value>Establece el valor del texto que será mostrado en pantalla como una ayuda</value>
    public TextMeshProUGUI textoMensaje;
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
    int puntajeAciertos;
    /// <value>Establece el valor de las veces que el usuario se ha equivocado</value>
    int puntajeErrores;

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
    public void RestarPuntaje()
    {
        puntajeErrores += 1;
        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    /// <summary>
    /// Muestra en pantalla los puntos que el usuario va obteniendo
    /// </summary>
    void ActualizarTextoPuntaje()
    {
        textoAciertos.text = "Aciertos " + puntajeAciertos.ToString();
        //textoErrores.text = "Errores " + puntajeErrores.ToString();
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