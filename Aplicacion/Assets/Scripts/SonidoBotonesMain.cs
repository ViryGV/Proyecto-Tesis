using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones del menú principal
/// </summary>
public class SonidoBotonesMain : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido del botón para jugar</value>
    [SerializeField]
    private AudioClip _sonidoJugar;
    /// <value>Variable serializada para almacenar el sonido del botón para las opciones</value>
    [SerializeField]
    private AudioClip _sonidoOpciones;
    /// <value>Variable serializada para almacenar el sonido del botón para salir</value>
    [SerializeField]
    private AudioClip _sonidoSalir;
    /// <value>Variable serializada para almacenar el sonido del botón para la información</value>
    [SerializeField]
    private AudioClip _sonidoInfo;
    /// <value>Variable serializada para almacenar el sonido del botón para cerrar los paneles</value>
    [SerializeField]
    private AudioClip _sonidoCerrar;
    /// <value>Variable serializada para almacenar el sonido del botón regresar (Menú Principal)</value>
    [SerializeField]
    private AudioClip _sonidoRegresar;
    /// <value>Variable serializada para almacenar el sonido del botón para el progreso</value>
    [SerializeField]
    private AudioClip _sonidoProgreso;
    /// <value>Variable serializada para almacenar el sonido del botón para borrar los datos</value>
    [SerializeField]
    private AudioClip _sonidoEliminar;

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
    public void ReproducirSonidoJugar()
    {
        _audioSource.PlayOneShot(_sonidoJugar);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoOpciones()
    {
        _audioSource.PlayOneShot(_sonidoOpciones);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoInfo()
    {
        _audioSource.PlayOneShot(_sonidoInfo);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoSalir()
    {
        _audioSource.PlayOneShot(_sonidoSalir);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoProgreso()
    {
        _audioSource.PlayOneShot(_sonidoProgreso);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoCerrar()
    {
        _audioSource.PlayOneShot(_sonidoCerrar);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoEliminar()
    {
        _audioSource.PlayOneShot(_sonidoEliminar);
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
