using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo de las oraciones que conforman
/// La narración de la historia y cuando deben aparecer las preguntas
/// </summary>
public class ControladorPuntosMemoriaHistoria : MonoBehaviour
{
    /// <value>Establece el valor de los aciertos que será mostrado en pantalla</value>
    public TextMeshProUGUI textoAciertos;
    TextMeshProUGUI textoGuardarAciertos;

    //Nivel Dos
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el segundo nivel</value>
    TextMeshProUGUI textoErroresDos;
    TextMeshProUGUI textoGuardarDos;
    TextMeshProUGUI textoErroresMaxDos;
    TextMeshProUGUI textoGuardarMaxDos;
    TextMeshProUGUI textoErroresMinDos;
    TextMeshProUGUI textoGuardarMinDos;


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
    public GameObject panelParteUno;
    public GameObject panelParteDos;
    public GameObject panelDUno;
    public GameObject panelDDos;
    public GameObject panelDTres;
    //public GameObject panelDCuatro;
    public GameObject panelParteTres;
    public GameObject panelTUno;
    public GameObject panelTDos;
    public GameObject panelTTres;
    //public GameObject panelTCuatro;
    public GameObject objetoUno;
    public GameObject objetoDos;
    public GameObject objetoTres;
    public GameObject objetoCuatro;
    public GameObject objetoCinco;
    public GameObject objetoHistoriaUno;
    public GameObject objetoHistoriaDos;
    public GameObject objetoHistoriaTres;
    public GameObject continuarDos;
    public GameObject continuarTres;

    /// <value>Establece el valor de las veces que aciertas</value>
    int puntajeAciertos;
    /// <value>Establece el valor de las veces que el usuario se ha equivocado</value>
    public static int puntajeErroresDos;
    public static int puntajeErroresMinDos;
    public static int puntajeErroresMaxDos;

    /// <value>Permite al acceso de los datos de la clase</value>
    ControladorJuego controladorJuego;

    /// <value>Acceder al valor de Renderer en los objetos para manipularlos</value>
    Renderer renderUno;
    Renderer renderDos;
    Renderer renderTres;
    Renderer renderCuatro;
    Renderer renderCinco;

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
        puntajeErroresDos = 0;
        puntajeErroresMaxDos = 0;
        puntajeErroresMinDos = 0;
        textoGuardarDos.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaDos", 0).ToString();
        textoGuardarMaxDos.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMaxDos", 0).ToString();
        textoGuardarMinDos.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0).ToString();
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
            DesactivarPanelParteUno();
            ActivarPanelParteDos();
            //DesactivarPanelTres();
            //ActivarPanelCuatro();
        }
        if (puntajeAciertos >= 4)
        {
            DesactivarPanelDUno();
            ActivarPanelDDos();
        }
        if (puntajeAciertos >= 5)
        {
            DesactivarPanelDDos();
            ActivarPanelDTres();
        }
        if (puntajeAciertos >= 6)
        {
            DesactivarPanelParteDos();
            ActivarPanelParteTres();
        }
        if (puntajeAciertos >= 7)
        {
            DesactivarPanelTUno();
            ActivarPanelTDos();
        }
        if (puntajeAciertos >= 8)
        {
            DesactivarPanelTDos();
            ActivarPanelTTres();
        }

        if (puntajeAciertos >= 9)
        {
            DesactivarPanelParteTres();
            controladorJuego.DesbloquearNivelMemoria();
        }
        /*else
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
    public void RestarPuntajeNivelDos()
    {
        puntajeErroresMaxDos++;
        puntajeErroresMinDos++;
        puntajeErroresDos++;

        if (puntajeErroresMaxDos > PlayerPrefs.GetInt("PuntajeErroresMemoriaMaxDos", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMaxDos", puntajeErroresMaxDos);
            Debug.Log("Errores Max dos " + puntajeErroresMaxDos);
        }
        else if (puntajeErroresMinDos <= PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMinDos", puntajeErroresMinDos);
            Debug.Log("Errores Min dos " + puntajeErroresMinDos);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaDos", puntajeErroresDos);
            Debug.Log("Errores Normal dos " + puntajeErroresDos);
        }

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
        //renderTres.enabled = false;
    }

    public void ActivarPanelCuatro()
    {
        panelCuatro.SetActive(true);
    }

    public void DesactivarPanelCuatro()
    {
        panelCuatro.SetActive(false);
    }

    public void DesactivarPanelParteUno()
    {
        panelParteUno.SetActive(false);
        objetoHistoriaUno.SetActive(false);
        renderTres.enabled = false;
    }

    public void ActivarPanelParteDos()
    {
        objetoHistoriaDos.SetActive(true);
        continuarDos.SetActive(true);
        renderTres.enabled = false;
        renderCuatro.enabled = true;
    }

    public void DesactivarPanelDUno()
    {
        panelDUno.SetActive(false);
        renderCuatro.enabled = false;
    }

    public void ActivarPanelDDos()
    {
        panelDDos.SetActive(true);
        continuarDos.SetActive(false);
    }

    public void DesactivarPanelDDos()
    {
        panelDDos.SetActive(false);
    }

    public void ActivarPanelDTres()
    {
        panelDTres.SetActive(true);
        renderDos.enabled = true;
    }

    public void DesactivarPanelDTres()
    {
        panelDTres.SetActive(false);
    }

    public void DesactivarPanelParteDos()
    {
        panelParteDos.SetActive(false);
        renderDos.enabled = false;
    }

    public void ActivarPanelParteTres()
    {
        objetoHistoriaTres.SetActive(true);
        continuarTres.SetActive(true);
        renderCuatro.enabled = true;
    }

    public void DesactivarPanelTUno()
    {
        panelTUno.SetActive(false);
        renderCuatro.enabled = false;
    }

    public void ActivarPanelTDos()
    {
        panelTDos.SetActive(true);
        renderUno.enabled = true;
        renderDos.enabled = true;
        continuarTres.SetActive(false);
    }

    public void DesactivarPanelTDos()
    {
        panelTDos.SetActive(false);
        renderDos.enabled = false;
    }

    public void ActivarPanelTTres()
    {
        panelTTres.SetActive(true);
        renderCinco.enabled = true;
    }

    public void DesactivarPanelTTres()
    {
        panelTTres.SetActive(false);
    }

    public void DesactivarPanelParteTres()
    {
        panelParteTres.SetActive(false);
    }
}
