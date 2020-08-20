using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo de todos los niveles
/// dispuestos en la aplicación
/// </summary>
public class ControladorJuego : MonoBehaviour
{
    /// <value>Establece un valor estático para saber que niveles (en emociones) se encuentran disponibles</value>
    static public int nivelesDisponibles;
    /// <value>Establece un valor estático para saber que niveles se encuentran disponibles</value>
    static public int nivelesDisponiblesAtencion;
    /// <value>Establece un valor estático para saber que niveles se encuentran disponibles</value>
    static public int nivelesDisponiblesInstrucciones;

    /// <value>Establece un valor estático para saber en que nivel (en emociones) te encuentras actualmente</value>
    public int nivelAcutal;
    /// <value>Establece un valor estático para saber en que nivel te encuentras actualmente</value>
    public int nivelAcutalAtencion;
    /// <value>Establece un valor estático para saber en que nivel te encuentras actualmente</value>
    public int nivelAcutalInstrucciones;

    /// <value>Arreglo de botones para poder desbloquearlos cuando la posición cambie</value>
    public Button[] botonesMenuEmociones;
    /// <value>Arreglo de botones para poder desbloquearlos cuando la posición cambie</value>
    public Button[] botonesMenuAtencion;
    /// <value>Arreglo de botones para poder desbloquearlos cuando la posición cambie</value>
    public Button[] botonesMenuInstrucciones;

    /// <value>Permite al acceso de los datos de la clase</value>
    CargarGuardar cargar_guardar;
    /// <value>Permite al acceso de los datos de la clase</value>
    ControladorMensajes mensaje;
    /// <value>Permite al acceso de los datos de la clase</value>
    ControladorMensajesAtencion mensajeAtencion;
    /// <value>Permite al acceso de los datos de la clase</value>
    ControladorMensajesInstrucciones mensajeInstrucciones;

    /// <summary>
    /// Inicializa las variables establecidas
    /// </summary>
    void Awake()
    {
        cargar_guardar = GetComponent<CargarGuardar>();
        mensaje = GetComponent<ControladorMensajes>();
        mensajeAtencion = GetComponent<ControladorMensajesAtencion>();
        mensajeInstrucciones = GetComponent<ControladorMensajesInstrucciones>();
    }

    /// <summary>
    /// Verifica que escena es la que se encuentra activa al momento
    /// de iniciar la aplicación, dependiendo de ello se activará una
    /// escena u otra
    /// </summary>
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "NivelesEmociones")
        {
            Debug.Log("Emociones");
            cargar_guardar.Guardar();
            ActualizarBotones();
        } else if (SceneManager.GetActiveScene().name == "NivelesAtencion")
        {
            Debug.Log("Atencion");
            cargar_guardar.Guardar();
            ActualizarBotonesAtencion();
        } else if (SceneManager.GetActiveScene().name == "NivelesInstruccionesVisuales")
        {
            Debug.Log("Instrucciones");
            cargar_guardar.Guardar();
            ActualizarBotones();
        }
    }

    /// <summary>Este método se encarga de ir desbloqueando los niveles
    /// según se van pasando</summary>
    /// <param name="nivel">El valor del nivel que será actualizado</param>
    public void ActualizarNivelEmociones(int nivel)
    {
        // Si el valor del nivel es cero, la escena se mantiene en el 
        // menú correspondiente
        // De lo contrario deberá cambiar al nivel que corresponda
        // de manera incremental
        if (nivel == 0)
        {
            Debug.Log("Menu emociones");
            SceneManager.LoadScene("NivelesEmociones");
        }
        else
        {
            SceneManager.LoadScene("EmocionesNivel" + nivel);
        }
    }

    /// <summary>Este método se encarga de ir desbloqueando los niveles
    /// según se van pasando</summary>
    /// <param name="nivel">El valor del nivel que será actualizado</param>
    public void ActualizarNivelAtencion(int nivel)
    {
        // Si el valor del nivel es cero, la escena se mantiene en el 
        // menú correspondiente
        // De lo contrario deberá cambiar al nivel que corresponda
        // de manera incremental
        Debug.Log("Actualizar atencion");
        if (nivel == 0)
        {
            Debug.Log("Menu");
            SceneManager.LoadScene("NivelesAtencion");
        }
        else
        {
            Debug.Log("else");
            SceneManager.LoadScene("AtencionNivel" + nivel);
        }
    }

    /// <summary>Este método se encarga de ir desbloqueando los niveles
    /// según se van pasando</summary>
    /// <param name="nivel">El valor del nivel que será actualizado</param>
    public void ActualizarNivelInstrucciones(int nivel)
    {
        // Si el valor del nivel es cero, la escena se mantiene en el 
        // menú correspondiente
        // De lo contrario deberá cambiar al nivel que corresponda
        // de manera incremental
        Debug.Log("Actualizar instrucciones");
        if (nivel == 0)
        {
            Debug.Log("Menu");
            SceneManager.LoadScene("NivelesInstruccionesVisuales");
        }
        else
        {
            Debug.Log("else");
            SceneManager.LoadScene("InstruccionesNivel" + nivel);
        }
    }

    /// <summary>
    /// Activa una pantalla que indica que el nivel ha sido superado (emociones)
    /// </summary>
    public void PantallaMensaje()
    {
        Debug.Log("Esperando");
        mensaje.CargarPanelMensaje();
    }

    /// <summary>
    /// Activa una pantalla que indica que el nivel ha sido superado
    /// </summary>
    public void PantallaMensajeAtencion()
    {
        Debug.Log("Esperando");
        mensajeAtencion.CargarPanelMensaje();
    }

    /// <summary>
    /// Activa una pantalla que indica que el nivel ha sido superado
    /// </summary>
    public void PantallaMensajeInstrucciones()
    {
        Debug.Log("Esperando");
        mensajeAtencion.CargarPanelMensaje();
    }

    /// <summary>
    /// Activa la opción de poder cambiar entre los niveles disponibles
    /// </summary>
    public void DesbloquearNivel()
    {
        // Cuando el valor del nivel disponible
        // sea menor al nivel actual, este deberá tomar el valor
        // del nivel actual.
        // Una vez que ha terminado carga un mensaje de nivel superado
        if (nivelesDisponibles < nivelAcutal)
        {
            nivelesDisponibles = nivelAcutal;
        }
        PantallaMensaje();
    }

    /// <summary>
    /// Activa la opción de poder cambiar entre los niveles disponibles
    /// </summary>
    public void DesbloquearNivelAtencion()
    {
        // Cuando el valor del nivel disponible
        // sea menor al nivel actual, este deberá tomar el valor
        // del nivel actual.
        // Una vez que ha terminado carga un mensaje de nivel superado
        if (nivelesDisponiblesAtencion < nivelAcutalAtencion)
        {
            nivelesDisponiblesAtencion = nivelAcutalAtencion;
        }
        PantallaMensajeAtencion();
    }

    /// <summary>
    /// Activa la opción de poder cambiar entre los niveles disponibles
    /// </summary>
    public void DesbloquearNivelInstrucciones()
    {
        // Cuando el valor del nivel disponible
        // sea menor al nivel actual, este deberá tomar el valor
        // del nivel actual.
        // Una vez que ha terminado carga un mensaje de nivel superado
        if (nivelesDisponiblesInstrucciones < nivelAcutalInstrucciones)
        {
            nivelesDisponiblesInstrucciones = nivelAcutalInstrucciones;
        }
        PantallaMensajeInstrucciones();
    }

    /// <summary>
    /// Permite hacer el cambio de un nivel (cualquiera) al menú
    /// de esa actividad/juego
    /// </summary>
    void RegresarMenu()
    {
        ActualizarNivelEmociones(0);
        ActualizarNivelAtencion(0);
        ActualizarNivelInstrucciones(0);
    }

    /// <summary>
    /// Activa la opción para poder interactuar con los botones de la escena
    /// </summary>
    public void ActualizarBotones()
    {
        /// <exception cref="IndexOutOfRangeException">
        /// En caso de no haber más elementos para recorrer los niveles
        /// </exception>
        try
        {
            for (int i = 0; i < nivelesDisponibles + 1; i++)
            {
                botonesMenuEmociones[i].interactable = true;
            }
        }
        catch (System.IndexOutOfRangeException)
        {
        }
    }

    /// <summary>
    /// Activa la opción para poder interactuar con los botones de la escena
    /// </summary>
    public void ActualizarBotonesAtencion()
    {
        /// <exception cref="IndexOutOfRangeException">
        /// En caso de no haber más elementos para recorrer los niveles
        /// </exception>
        try
        {
            for (int i = 0; i < nivelesDisponiblesAtencion + 1; i++)
            {
                botonesMenuAtencion[i].interactable = true;
            }
        }
        catch (System.IndexOutOfRangeException)
        {
        }
    }

    /// <summary>
    /// Activa la opción para poder interactuar con los botones de la escena
    /// </summary>
    public void ActualizarBotonesInstrucciones()
    {
        /// <exception cref="IndexOutOfRangeException">
        /// En caso de no haber más elementos para recorrer los niveles
        /// </exception>
        try
        {
            for (int i = 0; i < nivelesDisponiblesInstrucciones + 1; i++)
            {
                botonesMenuInstrucciones[i].interactable = true;
            }
        }
        catch (System.IndexOutOfRangeException)
        {
        }
    }
}
