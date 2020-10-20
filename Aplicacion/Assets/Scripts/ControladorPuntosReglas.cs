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
public class ControladorPuntosReglas : MonoBehaviour
{
    /// <value>Establece el valor de los aciertos que será mostrado en pantalla</value>
    public TextMeshProUGUI textoAciertos;
    TextMeshProUGUI textoGuardarAciertos;
    /// <value>Establece el valor del texto que será mostrado en pantalla como una ayuda</value>
    public TextMeshProUGUI textoMensaje;
    
    //Comedor
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

    //Escuela
    //Nivel Uno
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el tercer nivel</value>
    TextMeshProUGUI textoErroresTres;
    TextMeshProUGUI textoGuardarTres;
    TextMeshProUGUI textoErroresMaxTres;
    TextMeshProUGUI textoGuardarMaxTres;
    TextMeshProUGUI textoErroresMinTres;
    TextMeshProUGUI textoGuardarMinTres;

    //Nivel Dos
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el tercer nivel</value>
    TextMeshProUGUI textoErroresCuatro;
    TextMeshProUGUI textoGuardarCuatro;
    TextMeshProUGUI textoErroresMaxCuatro;
    TextMeshProUGUI textoGuardarMaxCuatro;
    TextMeshProUGUI textoErroresMinCuatro;
    TextMeshProUGUI textoGuardarMinCuatro;

    //Urbanidad
    //Nivel Uno
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el tercer nivel</value>
    TextMeshProUGUI textoErroresCinco;
    TextMeshProUGUI textoGuardarCinco;
    TextMeshProUGUI textoErroresMaxCinco;
    TextMeshProUGUI textoGuardarMaxCinco;
    TextMeshProUGUI textoErroresMinCinco;
    TextMeshProUGUI textoGuardarMinCinco;

    //Nivel Dos
    /// <value>Establece el valor interno de los errores que 
    /// será guardado en memoria para el tercer nivel</value>
    TextMeshProUGUI textoErroresSeis;
    TextMeshProUGUI textoGuardarSeis;
    TextMeshProUGUI textoErroresMaxSeis;
    TextMeshProUGUI textoGuardarMaxSeis;
    TextMeshProUGUI textoErroresMinSeis;
    TextMeshProUGUI textoGuardarMinSeis;

    public GameObject cosmo;

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
    public static int puntajeErroresCuatro;
    public static int puntajeErroresMinCuatro;
    public static int puntajeErroresMaxCuatro;
    public static int puntajeErroresCinco;
    public static int puntajeErroresMinCinco;
    public static int puntajeErroresMaxCinco;
    public static int puntajeErroresSeis;
    public static int puntajeErroresMinSeis;
    public static int puntajeErroresMaxSeis;
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
        puntajeErroresCuatro = 0;
        puntajeErroresMaxCuatro = 0;
        puntajeErroresMinCuatro = 0;
        puntajeErroresCinco = 0;
        puntajeErroresMaxCinco = 0;
        puntajeErroresMinCinco = 0;
        puntajeErroresSeis = 0;
        puntajeErroresMaxSeis = 0;
        puntajeErroresMinSeis = 0;
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
    public void SumarPuntajeComedorNivelUno()
    {
        puntajeAciertos ++;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 3)
        {
            controladorJuego.DesbloquearNivelComedor();
            controladorJuego.DesbloquearNivelAtencion();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosCUno", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosCUno", puntajeAciertos);
            }
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntajeComedorNivelDos()
    {
        puntajeAciertos++;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 3)
        {
            controladorJuego.DesbloquearNivelComedor();
            controladorJuego.DesbloquearNivelAtencion();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosCDos", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosCDos", puntajeAciertos);
            }
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntajeUrbanidadNivelUno()
    {
        puntajeAciertos++;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 3)
        {
            controladorJuego.DesbloquearNivelUrbanidad();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosUrUno", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosUrUno", puntajeAciertos);
            }
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntajeUrbanidadNivelDos()
    {
        puntajeAciertos++;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 3)
        {
            controladorJuego.DesbloquearNivelUrbanidad();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosUrDos", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosUrDos", puntajeAciertos);
            }
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntajeEscuelaNivelUno()
    {
        puntajeAciertos++;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 3)
        {
            controladorJuego.DesbloquearNivelEscuela();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosEscuelaUno", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosEscuelaUno", puntajeAciertos);
            }
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario acierta
    /// </summary>
    public void SumarPuntajeEscuelaNivelDos()
    {
        puntajeAciertos++;
        ActualizarTextoPuntaje();
        ActivarStatus();

        // Si el puntaje equivale al número indicado
        // se activa el panel siguiete y el superado 
        // es desactivado hasta superar el nivel por completo
        if (puntajeAciertos >= 3)
        {
            controladorJuego.DesbloquearNivelEscuela();
            if (puntajeAciertos > PlayerPrefs.GetInt("PuntajeAciertosEscuelaDos", 0))
            {
                PlayerPrefs.SetInt("PuntajeAciertosEscuelaDos", puntajeAciertos);
            }
        }
    }

    /// <summary>
    /// Método que va sumando las veces que el usuario se ha equivocado
    /// </summary>
    public void RestarPuntajeComedorNivelUno()
    {
        puntajeErroresMax++;
        puntajeErroresMin++;
        puntajeErrores++;

        if (puntajeErroresMax > PlayerPrefs.GetInt("PuntajeErroresReglasMax", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresReglasMax", puntajeErroresMax);
            Debug.Log("Errores Max " + puntajeErroresMax);

        }
        else if (puntajeErroresMin <= PlayerPrefs.GetInt("PuntajeErroresReglasMin", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresReglasMin", puntajeErroresMin);
            Debug.Log("Errores Min " + puntajeErroresMin);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresReglas", puntajeErrores);
            Debug.Log("Errores Normal " + puntajeErrores);
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeComedorNivelDos()
    {
        puntajeErroresMaxDos++;
        puntajeErroresMinDos++;
        puntajeErroresDos++;

        if (puntajeErroresMaxDos > PlayerPrefs.GetInt("PuntajeErroresReglasMaxDos", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresReglasMaxDos", puntajeErroresMaxDos);
            Debug.Log("Errores Max dos " + puntajeErroresMaxDos);
        }
        else if (puntajeErroresMinDos <= PlayerPrefs.GetInt("PuntajeErroresReglasMinDos", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresReglasMinDos", puntajeErroresMinDos);
            Debug.Log("Errores Min dos " + puntajeErroresMinDos);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresReglasDos", puntajeErroresDos);
            Debug.Log("Errores Normal dos " + puntajeErroresDos);
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeEscuelaNivelUno()
    {
        puntajeErroresMaxTres++;
        puntajeErroresMinTres++;
        puntajeErroresTres++;

        if (puntajeErroresMaxTres > PlayerPrefs.GetInt("PuntajeErroresReglasMaxTres", 0))
        {
            Debug.Log("if tres");
            PlayerPrefs.SetInt("PuntajeErroresReglasMaxTres", puntajeErroresMaxTres);
            Debug.Log("Errores Max " + puntajeErroresMaxTres);
        }
        else if (puntajeErroresMinTres <= PlayerPrefs.GetInt("PuntajeErroresReglasMinTres", 0))
        {
            Debug.Log("elese if 3");
            PlayerPrefs.SetInt("PuntajeErroresReglasMinTres", puntajeErroresMinTres);
            Debug.Log("Errores Min " + puntajeErroresMinTres);
        }
        else
        {
            Debug.Log("else 3");
            PlayerPrefs.SetInt("PuntajeErroresReglasTres", puntajeErroresTres);
            Debug.Log("Errores Normal " + puntajeErroresTres);
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeEscuelaNivelDos()
    {
        puntajeErroresMaxCuatro++;
        puntajeErroresMinCuatro++;
        puntajeErroresCuatro++;

        if (puntajeErroresMaxCuatro > PlayerPrefs.GetInt("PuntajeErroresReglasMaxCuatro", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresReglasMaxCuatro", puntajeErroresMaxCuatro);
            Debug.Log("Errores Max " + puntajeErroresMaxCuatro);

        }
        else if (puntajeErroresMinCuatro <= PlayerPrefs.GetInt("PuntajeErroresReglasMinCuatro", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresReglasMinCuatro", puntajeErroresMinCuatro);
            Debug.Log("Errores Min " + puntajeErroresMinCuatro);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresReglasCuatro", puntajeErroresCuatro);
            Debug.Log("Errores Normal " + puntajeErroresCuatro);
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }


    public void RestarPuntajeUrbanidadNivelUno()
    {
        puntajeErroresMaxCinco++;
        puntajeErroresMinCinco++;
        puntajeErroresCinco++;

        if (puntajeErroresMaxCinco > PlayerPrefs.GetInt("PuntajeErroresReglasMaxCinco", 0))
        {
            Debug.Log("if");
            PlayerPrefs.SetInt("PuntajeErroresReglasMaxCinco", puntajeErroresMaxCinco);
            Debug.Log("Errores Max 5 " + puntajeErroresMaxCinco);
        }
        else if (puntajeErroresMinCinco <= PlayerPrefs.GetInt("PuntajeErroresReglasMinCinco", 0))
        {
            Debug.Log("elese if");
            PlayerPrefs.SetInt("PuntajeErroresReglasMinCinco", puntajeErroresMinCinco);
            Debug.Log("Errores Min 5 " + puntajeErroresMinCinco);
        }
        else
        {
            Debug.Log("else");
            PlayerPrefs.SetInt("PuntajeErroresReglasCinco", puntajeErroresCinco);
            Debug.Log("Errores Normal 5 " + puntajeErroresCinco);
        }

        ActualizarTextoPuntaje();
        ActivarPistas();
    }

    public void RestarPuntajeUrbanidadNivelDos()
    {
        puntajeErroresMaxSeis++;
        puntajeErroresMinSeis++;
        puntajeErroresSeis++;

        if (puntajeErroresMaxSeis > PlayerPrefs.GetInt("PuntajeErroresReglasMaxSeis", 0))
        {
            Debug.Log("if tres");
            PlayerPrefs.SetInt("PuntajeErroresReglasMaxSeis", puntajeErroresMaxSeis);
            Debug.Log("Errores Max 6" + puntajeErroresMaxSeis);
        }
        else if (puntajeErroresMinSeis <= PlayerPrefs.GetInt("PuntajeErroresReglasMinSeis", 0))
        {
            Debug.Log("elese if 6");
            PlayerPrefs.SetInt("PuntajeErroresReglasMinSeis", puntajeErroresMinSeis);
            Debug.Log("Errores Min 6" + puntajeErroresMinSeis);
        }
        else
        {
            Debug.Log("else 6");
            PlayerPrefs.SetInt("PuntajeErroresReglasSeis", puntajeErroresSeis);
            Debug.Log("Errores Normal 6" + puntajeErroresSeis);
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
}
