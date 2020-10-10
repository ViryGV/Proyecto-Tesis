using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones de las opciones de instrucciones visuales
/// </summary>
public class SonidoBotonesReglas : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido del botón para la opción de 
    /// reglas del comedor</value>
    [SerializeField]
    private AudioClip _sonidoComedor;
    /// <value>Variable serializada para almacenar el sonido del botón para la opción de 
    /// reglas del salón de clases</value>
    [SerializeField]
    private AudioClip _sonidoEscuela;
    /// <value>Variable serializada para almacenar el sonido del botón para la opción de 
    /// reglas de urbanidad</value>
    [SerializeField]
    private AudioClip _sonidoUrbanidad;

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
    public void ReproducirSonidoComedor()
    {
        _audioSource.PlayOneShot(_sonidoComedor);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoEscuela()
    {
        _audioSource.PlayOneShot(_sonidoEscuela);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoUrbanidad()
    {
        _audioSource.PlayOneShot(_sonidoUrbanidad);
    }
}
