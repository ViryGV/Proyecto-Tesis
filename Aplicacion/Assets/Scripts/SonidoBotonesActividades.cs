using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones de las tarjetas de actividades
/// </summary>
public class SonidoBotonesActividades : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido del botón emociones en memoria</value>
    [SerializeField]
    private AudioClip _sonidoEmociones;
    /// <value>Variable serializada para almacenar el sonido del botón atención en memoria</value>
    [SerializeField]
    private AudioClip _sonidoAtencion;
    /// <value>Variable serializada para almacenar el sonido del botón memoria de trabajo en memoria</value>
    [SerializeField]
    private AudioClip _sonidoMemoria;
    /// <value>Variable serializada para almacenar el sonido del botón instrucciones en memoria</value>
    [SerializeField]
    private AudioClip _sonidoInstrucciones;

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
    public void ReproducirSonidoInstrucciones()
    {
        _audioSource.PlayOneShot(_sonidoInstrucciones);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoMemoria()
    {
        _audioSource.PlayOneShot(_sonidoMemoria);
    }
}
