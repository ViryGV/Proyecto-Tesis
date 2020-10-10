using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones de las profesiones - oficios y los botones 
/// de navegación del menú
/// </summary>
public class SonidoBotonesProfesiones : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido del botón para la sección de veterinarios</value>
    [SerializeField]
    private AudioClip _sonidoVeterinario;
    /// <value>Variable serializada para almacenar el sonido del botón para la sección de bomberos</value>
    [SerializeField]
    private AudioClip _sonidoBombero;
    /// <value>Variable serializada para almacenar el sonido del botón regresar (Menú Juegos)</value>
    [SerializeField]
    private AudioClip _sonidoRegresar;
    /// <value>Variable serializada para almacenar el sonido del botón inicio (Menú Profesiones - Oficios)</value>
    [SerializeField]
    private AudioClip _sonidoInicio;
    /// <value>Variable serializada para almacenar el sonido del botón para iniciar con la narración</value>
    [SerializeField]
    private AudioClip _sonidoStart;
    /// <value>Variable serializada para almacenar el sonido del botón para pasar a la siguiente página</value>
    [SerializeField]
    private AudioClip _sonidoSiguiente;
    /// <value>Variable serializada para almacenar el sonido del botón para regresar a la página anterior</value>
    [SerializeField]
    private AudioClip _sonidoAnterior;
    /// <value>Variable serializada para almacenar el sonido del botón para pasar terminar con la sección</value>
    [SerializeField]
    private AudioClip _sonidoTerminar;
    /// <value>Variable serializada para almacenar el sonido del botón para reiniciar la narración</value>
    [SerializeField]
    private AudioClip _sonidoReiniciar;

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
    public void ReproducirSonidoVeterinario()
    {
        _audioSource.PlayOneShot(_sonidoVeterinario);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoBombero()
    {
        _audioSource.PlayOneShot(_sonidoBombero);
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
    public void ReproducirSonidoStart()
    {
        _audioSource.PlayOneShot(_sonidoStart);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoSiguiente()
    {
        _audioSource.PlayOneShot(_sonidoSiguiente);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoAnterior()
    {
        _audioSource.PlayOneShot(_sonidoAnterior);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoReiniciar()
    {
        _audioSource.PlayOneShot(_sonidoReiniciar);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoTerminar()
    {
        _audioSource.PlayOneShot(_sonidoTerminar);
    }
}
