using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorPuntosInstrucciones : MonoBehaviour
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
    /// </list>
    /// </summary>
    public GameObject cosmo;
    public GameObject panelUno;
    public GameObject panelDos;
    public GameObject panelTres;
    public GameObject panelCuatro;
    public GameObject objetoUno;
    public GameObject objetoDos;
    public GameObject objetoTres;

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

    /// <summary>
    /// Inicializa las variables establecidas
    /// </summary>
    void Start()
    {
        renderUno = objetoUno.GetComponent<Renderer>();
        renderDos = objetoDos.GetComponent<Renderer>();
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
            Debug.Log("if 2");
            Debug.Log("puntaje 2");
            DesactivarPanelDos();
            ActivarPanelTres();
        }
        if (puntajeAciertos >= 3)
        {
            Debug.Log("if 3");
            Debug.Log("puntaje 3");
            DesactivarPanelTres();
            ActivarPanelCuatro();
        }
        if (puntajeAciertos >= 6 || puntajeAciertos >= 3)
        {
            Debug.Log("if bonus");
            Debug.Log("Puntos " + puntajeAciertos);
            Debug.Log("Tienes un bonus");
            //controladorJuego.DesbloquearNivelInstrucciones();
        } /*else
        {
            Debug.Log("Puntos " + puntajeAciertos);
            Debug.Log("NO Tienes un bonus");
            DesactivarPanelCuatro();
        }*/
        /*if (puntajeAciertos >= 6)
        {
            Debug.Log("Puntos " + puntajeAciertos);
            Debug.Log("Tienes un bonus");
            //DesactivarPanelCuatro();
            controladorJuego.DesbloquearNivelInstrucciones();
        } else
        {
            //DesactivarPanelCuatro();
            Debug.Log("Puntos " + puntajeAciertos);
            Debug.Log("NO Tienes un bonus");
            //controladorJuego.DesbloquearNivelInstrucciones();
        }*/

        /*if (puntajeAciertos >= 6)
        {
            controladorJuego.DesbloquearNivelInstrucciones();
        }*/
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
    /// Método que va sumando las veces que el usuario se ha equivocado
    /// </summary>
    public void PuntajeBonus()
    {
        puntajeAciertos += 3;
        ActualizarTextoPuntaje();
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
}
