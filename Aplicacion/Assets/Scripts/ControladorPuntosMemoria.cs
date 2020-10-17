using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ControladorPuntosMemoria : MonoBehaviour
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
    public GameObject objetoDos;
    public GameObject objetoTres;
    public GameObject botonUno;
    public GameObject botonDos;
    public GameObject botonTres;
    public GameObject panelUno;
    public GameObject panelDos;
    public GameObject panelTres;
    public GameObject panelParteUno;
    public GameObject panelParteDos;
    public GameObject panelParteTres;

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
    public static int puntajeErroresTres;
    public static int puntajeErroresMinTres;
    public static int puntajeErroresMaxTres;
    /// <value>Establece el valor flotante del tiempo de vida que tiene en pantalla los cuadros de diálogo</value>
    float tiempoVida;

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
            ActivarPanelParteDos();
        }
        if (puntajeAciertos >= 2)
        {
            Debug.Log("if 2");
            Debug.Log("puntaje 2");
            DesactivarPanelDos();
            ActivarPanelParteTres();
        }
        
        if (puntajeAciertos >= 3)
        {
            Debug.Log("if 3");
            Debug.Log("puntaje 3");
            DesactivarPanelTres();
            controladorJuego.DesbloquearNivelMemoria();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosMUno", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosMUno", puntajeAciertos);
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
            DesactivarPanelUno();
            ActivarPanelParteDos();
        }
        if (puntajeAciertos >= 2)
        {
            Debug.Log("if 2");
            Debug.Log("puntaje 2");
            DesactivarPanelDos();
            ActivarPanelParteTres();
        }

        if (puntajeAciertos >= 3)
        {
            Debug.Log("if 3");
            Debug.Log("puntaje 3");
            DesactivarPanelTres();
            controladorJuego.DesbloquearNivelMemoria();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosMTres", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosMTres", puntajeAciertos);
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

        if ((puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresMemoriaActuales", 0)) &&
            (puntajeErrores > PlayerPrefs.GetInt("PuntajeErroresMemoria", 0)))
        {
            Debug.Log("if n1");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaActuales", puntajeErroresMax);
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMin", puntajeErroresMin);
            Debug.Log("Errores Max  " + puntajeErroresMax);
        }
        else if ((puntajeErroresMin < PlayerPrefs.GetInt("PuntajeErroresMemoriaActuales", 0)) &&
            (puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresMemoria", 0)))
        {
            Debug.Log("elese if n1");
            PlayerPrefs.SetInt("PuntajeErroresMemoria", puntajeErrores);
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMin", puntajeErroresMin);
            Debug.Log("Errores max en else if n1  " + puntajeErroresMax);
        }
        else
        {
            Debug.Log("else n1");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaActuales", puntajeErroresMin);
            Debug.Log("Errores Min n2 " + puntajeErroresMin);
            Debug.Log("Errores Max n2 " + puntajeErroresMax);
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeNivelTres()
    {
        puntajeErroresMaxTres++;
        puntajeErroresMinTres++;
        puntajeErroresTres++;

        if ((puntajeErroresMaxTres > PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesTres", 0)) &&
            (puntajeErroresTres > PlayerPrefs.GetInt("PuntajeErroresMemoriaTres", 0)))
        {
            Debug.Log("if n3");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaActualesTres", puntajeErroresMaxTres);
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMinTres", puntajeErroresMinTres);
            Debug.Log("Errores Max tres " + puntajeErroresMaxTres);
        }
        else if ((puntajeErroresTres < PlayerPrefs.GetInt("PuntajeErroresMemoriaActualesTres", 0)) &&
            (puntajeErroresMaxTres > PlayerPrefs.GetInt("PuntajeErroresMemoriaTres", 0)))
        {
            Debug.Log("elese if n3");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaTres", puntajeErroresTres);
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMinTres", puntajeErroresMinTres);
            Debug.Log("Errores max en else if tres " + puntajeErroresMaxTres);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaActualesTres", puntajeErroresMinTres);
            Debug.Log("Errores Min n3 " + puntajeErroresMinTres);
            Debug.Log("Errores Max n3 " + puntajeErroresMaxTres);
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
        botonUno.SetActive(false);
    }

    public void DesactivarPanelUno()
    {
        panelUno.SetActive(false);
        objetoDos.SetActive(true);
        botonDos.SetActive(true);
    }

    public void ActivarPanelDos()
    {
        panelDos.SetActive(true);
        botonDos.SetActive(false);
    }

    public void DesactivarPanelDos()
    {
        panelDos.SetActive(false);
        objetoTres.SetActive(true);
        botonTres.SetActive(true);
        botonDos.SetActive(false);
    }

    public void ActivarPanelTres()
    {
        panelTres.SetActive(true);
        botonDos.SetActive(false);
        botonTres.SetActive(false);
    }

    public void DesactivarPanelTres()
    {
        panelTres.SetActive(false);
    }

    public void DesactivarPanelParteUno()
    {
        panelParteUno.SetActive(false);
    }

    public void ActivarPanelParteDos()
    {
        panelParteDos.SetActive(true);
    }

    public void DesactivarPanelParteDos()
    {
        panelParteDos.SetActive(false);
    }

    public void ActivarPanelParteTres()
    {
        panelParteTres.SetActive(true);
    }

    public void DesactivarPanelParteTres()
    {
        panelParteTres.SetActive(false);
    }
}