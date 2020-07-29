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
public class ControladorPuntos : MonoBehaviour
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
    /// <term>panelAlegría</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelEnojo</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelTristeza</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelSorpresa</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelTemor</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelAburrido</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelPreocupado</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>panelCansado</term>
    /// <description>Panel que contiene los elementos de ese objetivo</description>
    /// </item>
    /// <item>
    /// <term>objetoAlegría</term>
    /// <description>Es un elemento que contiene el sprite (imagen) que describe</description>
    /// </item>
    /// <item>
    /// <term>objetoEnojo</term>
    /// <description>Es un elemento que contiene el sprite (imagen) que describe</description>
    /// </item>
    /// <item>
    /// <term>objetoTristeza</term>
    /// <description>Es un elemento que contiene el sprite (imagen) que describe</description>
    /// </item>
    /// <item>
    /// <term>objetoSorpresa</term>
    /// <description>Es un elemento que contiene el sprite (imagen) que describe</description>
    /// </item>
    /// <item>
    /// <term>objetoTemor</term>
    /// <description>Es un elemento que contiene el sprite (imagen) que describe</description>
    /// </item>
    /// <item>
    /// <term>objetoAburrido</term>
    /// <description>Es un elemento que contiene el sprite (imagen) que describe</description>
    /// </item>
    /// <item>
    /// <term>objetoPreocupado</term>
    /// <description>Es un elemento que contiene el sprite (imagen) que describe</description>
    /// </item>
    /// <item>
    /// <term>objetoCansado</term>
    /// <description>Es un elemento que contiene el sprite (imagen) que describe</description>
    /// </item>
    /// </list>
    /// </summary>
    public GameObject cosmo;
    public GameObject panelAlegria;
    public GameObject panelEnojo;
    public GameObject panelTristeza;
    public GameObject panelSopresa;
    public GameObject panelTemor;
    public GameObject panelAburrido;
    public GameObject panelPreocupado;
    public GameObject panelCansado;
    public GameObject objetoAlegria;
    public GameObject objetoEnojo;
    public GameObject objetoTristeza;
    public GameObject objetoSorpresa;
    public GameObject objetoTemor;
    public GameObject objetoAburrido;
    public GameObject objetoPreocupado;
    public GameObject objetoCansado;

    /// <value>Establece el valor de las veces que aciertas</value>
    int puntajeAciertos;
    /// <value>Establece el valor de las veces que el usuario se ha equivocado</value>
    int puntajeErrores;

    /// <value>Permite al acceso de los datos de la clase</value>
    ControladorJuego controladorJuego;

    /// <value>Acceder al valor de Renderer en los objetos para manipularlos</value>
    Renderer render;
    Renderer renderE;
    Renderer renderT;
    Renderer renderS;
    Renderer renderA;
    Renderer renderP;
    Renderer renderC;
    Renderer renderTemor;

    /// <summary>
    /// Inicializa las variables establecidas
    /// </summary>
    void Start()
    {
        render = objetoAlegria.GetComponent<Renderer>();
        renderE = objetoEnojo.GetComponent<Renderer>();
        renderT = objetoTristeza.GetComponent<Renderer>();
        renderS = objetoSorpresa.GetComponent<Renderer>();
        renderA = objetoAburrido.GetComponent<Renderer>();
        renderP = objetoPreocupado.GetComponent<Renderer>();
        renderTemor = objetoTemor.GetComponent<Renderer>();
        renderC = objetoCansado.GetComponent<Renderer>();
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

    public void ActivarPanelAlegria()
    {
        panelAlegria.SetActive(true);
        render.enabled = true;
    }

    public void DesactivarPanelAlegria()
    {
        panelAlegria.SetActive(false);
        render.enabled = false;
    }

    public void ActivarPanelEnojo()
    {
        panelEnojo.SetActive(true);
        renderE.enabled = true;
    }

    public void DesactivarPanelEnojo()
    {
        panelEnojo.SetActive(false);
        renderE.enabled = false;
    }

    public void ActivarPanelTristeza()
    {
        panelTristeza.SetActive(true);
        renderT.enabled = true;
    }

    public void DesactivarPanelTristeza()
    {
        panelTristeza.SetActive(false);
        renderT.enabled = false;
    }

    public void ActivarPanelSorpresa()
    {
        panelSopresa.SetActive(true);
        renderS.enabled = true;
    }

    public void DesactivarPanelSorpresa()
    {
        panelSopresa.SetActive(false);
        renderS.enabled = false;
    }

    public void ActivarPanelTemor()
    {
        panelTemor.SetActive(true);
        renderTemor.enabled = true;
    }

    public void DesactivarPanelTemor()
    {
        panelTemor.SetActive(false);
        renderTemor.enabled = false;
    }

    public void ActivarPanelAburrido()
    {
        panelAburrido.SetActive(true);
        renderA.enabled = true;
    }

    public void DesactivarPanelAburrido()
    {
        panelAburrido.SetActive(false);
        renderA.enabled = false;
    }

    public void ActivarPanelPreocupado()
    {
        panelPreocupado.SetActive(true);
        renderP.enabled = true;
    }

    public void DesactivarPanelPreocupado()
    {
        panelPreocupado.SetActive(false);
        renderP.enabled = false;
    }

    public void ActivarPanelCansado()
    {
        panelCansado.SetActive(true);
        renderC.enabled = true;
    }

    public void DesactivarPanelCansado()
    {
        panelCansado.SetActive(false);
        renderC.enabled = false;
    }
}