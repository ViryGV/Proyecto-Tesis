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
    public static int puntajeErroresDos;
    public static int puntajeErroresMinDos;
    public static int puntajeErroresMaxDos;
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
        puntajeErroresDos = 0;
        puntajeErroresMaxDos = 0;
        puntajeErroresMinDos = 0;
        puntajeAciertos = 0;
        textoGuardar.text = PlayerPrefs.GetInt("PuntajeErroresMemoria", 0).ToString();
        textoGuardarMax.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMax", 0).ToString();
        textoGuardarMin.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMin", 0).ToString();
        textoGuardarDos.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaDos", 0).ToString();
        textoGuardarMaxDos.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMaxDos", 0).ToString();
        textoGuardarMinDos.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0).ToString();
        textoGuardarTres.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaTres", 0).ToString();
        textoGuardarMaxTres.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMaxTres", 0).ToString();
        textoGuardarMinTres.text = PlayerPrefs.GetInt("PuntajeErroresMemoriaMinTres", 0).ToString();
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

        if (puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresMemoriaMax", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMax", puntajeErroresMax);
            Debug.Log("Errores Max  " + puntajeErroresMax);
        }
        else if (puntajeErroresMin <= PlayerPrefs.GetInt("PuntajeErroresMemoriaMin", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMin", puntajeErroresMin);
            Debug.Log("Errores Min  " + puntajeErroresMin);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresMemoria", puntajeErrores);
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

        if (puntajeErroresMaxDos > PlayerPrefs.GetInt("PuntajeErroresMemoriaMaxDos", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMaxDos", puntajeErroresMaxDos);
            Debug.Log("Errores Max dos " + puntajeErroresMaxDos);
        }
        else if (puntajeErroresMin <= PlayerPrefs.GetInt("PuntajeErroresMemoriaMinDos", 0))
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

    public void RestarPuntajeNivelTres()
    {
        puntajeErroresMaxTres++;
        puntajeErroresMinTres++;
        puntajeErroresTres++;

        if (puntajeErroresMaxTres > PlayerPrefs.GetInt("PuntajeErroresMemoriaMaxTres", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMaxTres", puntajeErroresMaxTres);
            Debug.Log("Errores Max tres " + puntajeErroresMaxTres);
        }
        else if (puntajeErroresMinTres <= PlayerPrefs.GetInt("PuntajeErroresMemoriaMinTres", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaMinTres", puntajeErroresMinTres);
            Debug.Log("Errores Min tres " + puntajeErroresMinTres);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresMemoriaTres", puntajeErroresTres);
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
