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
}
