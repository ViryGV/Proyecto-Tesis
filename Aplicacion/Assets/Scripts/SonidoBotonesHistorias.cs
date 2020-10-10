using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones de las historias y los botones 
/// de navegación del menú
/// </summary>
public class SonidoBotonesHistorias : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido de los botones historia 1 a 3</value>
    [SerializeField]
    private AudioClip _sonidoHistorias;
    /// <value>Variable serializada para almacenar el sonido del botón regresar (Menú de Juegos)</value>
    [SerializeField]
    private AudioClip _sonidoRegresar;
    /// <value>Variable serializada para almacenar el sonido del botón inicio (Menú Principal)</value>
    [SerializeField]
    private AudioClip _sonidoInicio;
    /// <value>Variable serializada para almacenar el sonido del botón volver (Menú Historias)</value>
    [SerializeField]
    private AudioClip _sonidoVolver;

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
    public void ReproducirSonidoHistorias()
    {
        _audioSource.PlayOneShot(_sonidoHistorias);
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
    public void ReproducirSonidoInicio()
    {
        _audioSource.PlayOneShot(_sonidoInicio);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoVolver()
    {
        _audioSource.PlayOneShot(_sonidoVolver);
    }
}
