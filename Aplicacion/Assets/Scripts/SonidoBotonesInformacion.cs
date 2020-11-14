using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones de la sección de progreso y los botones
/// de navegación del menú
/// </summary>
public class SonidoBotonesInformacion : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido del botón de la información de las tarjetas </value>
    [SerializeField]
    private AudioClip _sonidoActividades;
    /// <value>Variable serializada para almacenar el sonido del botón de la información de las historias</value>
    [SerializeField]
    private AudioClip _sonidoHistorias;
    /// <value>Variable serializada para almacenar el sonido del botón de la información del pensamiento matemático </value>
    [SerializeField]
    private AudioClip _sonidoMatematicas;
    /// <value>Variable serializada para almacenar el sonido del botón regresar (Menú Principal) </value>
    [SerializeField]
    private AudioClip _sonidoRegresar;
    /// <value>Variable serializada para almacenar el sonido del botón reconocimiento de emociones </value>
    [SerializeField]
    private AudioClip _sonidoEmociones;
    /// <value>Variable serializada para almacenar el sonido del botón reconocimiento de emociones </value>
    [SerializeField]
    private AudioClip _sonidoAtencion;
    /// <value>Variable serializada para almacenar el sonido del botón atención </value>
    [SerializeField]
    private AudioClip _sonidoMemoria;
    /// <value>Variable serializada para almacenar el sonido del botón instrucciones visuales </value>
    [SerializeField]
    private AudioClip _sonidoInstrucciones;
    /// <value>Variable serializada para almacenar el sonido del botón atras (selección de información) </value>
    [SerializeField]
    private AudioClip _sonidoAtras;
    /// <value>Variable serializada para almacenar el sonido de los botones para el nivel uno </value>
    [SerializeField]
    private AudioClip _sonidoNivelUno;
    /// <value>Variable serializada para almacenar el sonido de los botones para el nivel dos </value>
    [SerializeField]
    private AudioClip _sonidoNivelDos;
    /// <value>Variable serializada para almacenar el sonido de los botones para el nivel tres </value>
    [SerializeField]
    private AudioClip _sonidoNivelTres;

    /// <summary>
    /// Inicializa las variables establecidas
    /// </summary>
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoActividades()
    {
        _audioSource.PlayOneShot(_sonidoActividades);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoHistorias()
    {
        _audioSource.PlayOneShot(_sonidoHistorias);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoMatematicas()
    {
        _audioSource.PlayOneShot(_sonidoMatematicas);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoEmociones()
    {
        _audioSource.PlayOneShot(_sonidoEmociones);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoAtencion()
    {
        _audioSource.PlayOneShot(_sonidoAtencion);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoMemoria()
    {
        _audioSource.PlayOneShot(_sonidoMemoria);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoInstrucciones()
    {
        _audioSource.PlayOneShot(_sonidoInstrucciones);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoAtras()
    {
        _audioSource.PlayOneShot(_sonidoAtras);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoNivelUno()
    {
        _audioSource.PlayOneShot(_sonidoNivelUno);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoNivelDos()
    {
        _audioSource.PlayOneShot(_sonidoNivelDos);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoNivelTres()
    {
        _audioSource.PlayOneShot(_sonidoNivelTres);
    }
}
