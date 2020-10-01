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
    TextMeshProUGUI textoGuardarAciertos;

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
        /*textoGuardar.text = PlayerPrefs.GetInt("PuntajeErrores", 0).ToString();
        textoGuardarMax.text = PlayerPrefs.GetInt("PuntajeErroresMax", 0).ToString();
        textoGuardarMin.text = PlayerPrefs.GetInt("PuntajeErroresMin", 0).ToString();
        textoGuardarDos.text = PlayerPrefs.GetInt("PuntajeErroresDos", 0).ToString();
        textoGuardarMaxDos.text = PlayerPrefs.GetInt("PuntajeErroresMaxDos", 0).ToString();
        textoGuardarMinDos.text = PlayerPrefs.GetInt("PuntajeErroresMinDos", 0).ToString();
        textoGuardarTres.text = PlayerPrefs.GetInt("PuntajeErroresTres", 0).ToString();
        textoGuardarMaxTres.text = PlayerPrefs.GetInt("PuntajeErroresMaxTres", 0).ToString();
        textoGuardarMinTres.text = PlayerPrefs.GetInt("PuntajeErroresMinTres", 0).ToString();
        textoGuardarAciertos.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();
        textoGuardarAciertos.text = PlayerPrefs.GetInt("PuntajeAciertos", 0).ToString();*/
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
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertos", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertos", puntajeAciertos);
            }
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

        if (puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresMax", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresMax", puntajeErroresMax);
            PlayerPrefs.SetInt("PuntajeErroresMin", puntajeErroresMax);
            Debug.Log("Errores Max " + puntajeErroresMax);

        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresMax", puntajeErroresMin);
            Debug.Log("Errores Min " + puntajeErroresMin);
            Debug.Log("Errores Min con max" + puntajeErroresMax);
        }

        /*if (puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresMax", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresMax", puntajeErroresMax);
            Debug.Log("Errores Max " + puntajeErroresMax);

        }
        else if (puntajeErroresMin <= PlayerPrefs.GetInt("PuntajeErroresMin", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresMin", puntajeErroresMin);
            Debug.Log("Errores Min " + puntajeErroresMin);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErrores", puntajeErrores);
            Debug.Log("Errores Normal " + puntajeErrores);
        }*/

        ActualizarTextoPuntaje();
        ActivarPistas();
    }


    public void RestarPuntajeNivelDos()
    {
        puntajeErroresMaxDos++;
        puntajeErroresMinDos++;
        puntajeErroresDos++;

        Debug.Log(puntajeErroresMaxDos);

        //Max --> ACTUALES y Min --> ANTERIORES
        /*if ((puntajeErroresMaxDos > PlayerPrefs.GetInt("PuntajeErroresMaxDos", 0)) 
            || (puntajeErroresMinDos <= PlayerPrefs.GetInt("PuntajeErroresMinDos", 0)))*/
        if ((puntajeErroresMaxDos > PlayerPrefs.GetInt("PuntajeErroresActualesDos", 0)) && 
            (puntajeErroresDos > PlayerPrefs.GetInt("PuntajeErroresDos", 0)))
        //if (puntajeErroresMaxDos != 0)
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresActualesDos", puntajeErroresMaxDos);
            PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMinDos);
            //PlayerPrefs.SetInt("PuntajeErroresDos", puntajeErroresDos);
            Debug.Log("Errores Max " + puntajeErroresMaxDos);

        } else if(puntajeErroresDos > PlayerPrefs.GetInt("PuntajeErroresDos", 0))
        {
            Debug.Log("else if " + puntajeErroresDos);
            //PlayerPrefs.SetInt("PuntajeErroresActualesDos", puntajeErroresDos);
            PlayerPrefs.SetInt("PuntajeErroresDos", puntajeErroresDos);
            Debug.Log("Errores max en else if " + puntajeErroresMaxDos);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresActualesDos", puntajeErroresMinDos);
            //PlayerPrefs.SetInt("PuntajeErroresDos", puntajeErroresDos);
            //PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMaxDos);
            //PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMaxDos);
            Debug.Log("Errores Min " + puntajeErroresMinDos);
            Debug.Log("Errores Max " + puntajeErroresMaxDos);
        }
        if (puntajeErroresMin <= PlayerPrefs.GetInt("PuntajeErroresMinDos", 0))
        {
            Debug.Log("if probando");
            //PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMaxDos);
        }
        /*else
        {
            Debug.Log("else probando");
            PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMaxDos);
            PlayerPrefs.SetInt("PuntajeErroresMaxDos", puntajeErroresMinDos);
            //PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMaxDos);
            Debug.Log("Errores Min " + puntajeErroresMinDos);
            Debug.Log("Errores Max " + puntajeErroresMaxDos);
        }*/
        /*else if (puntajeErroresMinDos > puntajeErroresMaxDos)
        {
            Debug.Log("else if");
            PlayerPrefs.SetInt("PuntajeErroresMaxDos", puntajeErroresMinDos);
            Debug.Log("Min else if " + puntajeErroresMinDos);
        }*/
        /*else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresMaxDos", puntajeErroresMinDos);
            PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMaxDos);
            //PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMaxDos);
            Debug.Log("Errores Min " + puntajeErroresMinDos);
            Debug.Log("Errores Max " + puntajeErroresMaxDos);
        }*/
        Debug.Log("Contar min " + puntajeErroresMinDos);
        Debug.Log("Contar max " + puntajeErroresMaxDos);
        //PlayerPrefs.SetInt("PuntajeErroresMaxDos", puntajeErroresMinDos);

        /*if (puntajeErroresMaxDos > PlayerPrefs.GetInt("PuntajeErroresMaxDos", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresMaxDos", puntajeErroresMaxDos);
            Debug.Log("Errores Max dos " + puntajeErroresMaxDos);
        }
        else if (puntajeErroresMinDos <= PlayerPrefs.GetInt("PuntajeErroresMinDos", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresMinDos", puntajeErroresMinDos);
            Debug.Log("Errores Min dos " + puntajeErroresMinDos);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresDos", puntajeErroresDos);
            Debug.Log("Errores Normal dos " + puntajeErroresDos);
        }*/

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeNivelTres()
    {
        puntajeErroresMaxTres++;
        puntajeErroresMinTres++;
        puntajeErroresTres++;

        if (puntajeErroresMaxTres > PlayerPrefs.GetInt("PuntajeErroresMaxTres", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresMaxTres", puntajeErroresMaxTres);
            PlayerPrefs.SetInt("PuntajeErroresMinTres", puntajeErroresMaxTres);
            Debug.Log("Errores Max 3 " + puntajeErroresMaxTres);

        }
        else
        {
            Debug.Log("else 3");
            PlayerPrefs.SetInt("PuntajeErroresMaxTres", puntajeErroresMinTres);
            Debug.Log("Errores 3 Min " + puntajeErroresMinTres);
        }

        /*if (puntajeErroresMaxTres > PlayerPrefs.GetInt("PuntajeErroresMaxTres", 0))
        {
            Debug.Log("if tres");
            PlayerPrefs.SetInt("PuntajeErroresMaxTres", puntajeErroresMaxTres);
            Debug.Log("Errores Max " + puntajeErroresMaxTres);
        }
        else if (puntajeErroresMinTres <= PlayerPrefs.GetInt("PuntajeErroresMinTres", 0))
        {
            Debug.Log("elese if 3");
            PlayerPrefs.SetInt("PuntajeErroresMinTres", puntajeErroresMinTres);
            Debug.Log("Errores Min " + puntajeErroresMinTres);
        }
        else
        {
            Debug.Log("else 3");
            PlayerPrefs.SetInt("PuntajeErroresTres", puntajeErroresTres);
            Debug.Log("Errores Normal " + puntajeErroresTres);
        }*/

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