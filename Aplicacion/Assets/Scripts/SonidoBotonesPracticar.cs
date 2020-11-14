using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones de las opciones en la sección de practicar 
/// y los botones de navegación del menú
/// </summary>
public class SonidoBotonesPracticar : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido del botón sumar</value>
    [SerializeField]
    private AudioClip _sonidoSumar;
    /// <value>Variable serializada para almacenar el sonido del botón multiplicar</value>
    [SerializeField]
    private AudioClip _sonidoMultiplicar;
    /// <value>Variable serializada para almacenar el sonido del botón restar</value>
    [SerializeField]
    private AudioClip _sonidoRestar;
    /// <value>Variable serializada para almacenar el sonido del botón dividir</value>
    [SerializeField]
    private AudioClip _sonidoDividir;
    /// <value>Variable serializada para almacenar el sonido del botón regresar (Menú de Juegos)</value>
    [SerializeField]
    private AudioClip _sonidoRegresar;
    /// <value>Variable serializada para almacenar el sonido del botón inicio (Menú Principal)</value>
    [SerializeField]
    private AudioClip _sonidoInicio;

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
    public void ReproducirSonidoSumar()
    {
        _audioSource.PlayOneShot(_sonidoSumar);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoMultiplicar()
    {
        _audioSource.PlayOneShot(_sonidoMultiplicar);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoRestar()
    {
        _audioSource.PlayOneShot(_sonidoRestar);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoDividir()
    {
        _audioSource.PlayOneShot(_sonidoDividir);
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
    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }
}
