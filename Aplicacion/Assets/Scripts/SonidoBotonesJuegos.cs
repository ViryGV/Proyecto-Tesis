using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones del menú de juegos y los botones 
/// de navegación del menú
/// </summary>
public class SonidoBotonesJuegos : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido del botón para las tarjetas</value>
    [SerializeField]
    private AudioClip _sonidoActividades;
    /// <value>Variable serializada para almacenar el sonido del botón regresar (Menú Juegos)</value>
    [SerializeField]
    private AudioClip _sonidoRegresar;
    /// <value>Variable serializada para almacenar el sonido del botón regresar (Menú Principal)</value>
    [SerializeField]
    private AudioClip _sonidoMenu;
    /// <value>Variable serializada para almacenar el sonido del botón para las historias</value>
    [SerializeField]
    private AudioClip _sonidoHistorias;
    /// <value>Variable serializada para almacenar el sonido del botón para las profesiones y oficios</value>
    [SerializeField]
    private AudioClip _sonidoProfesiones;
    /// <value>Variable serializada para almacenar el sonido del botón para el pensamiento matemático</value>
    [SerializeField]
    private AudioClip _sonidoPracticar;

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
    public void ReproducirSonidoMenu()
    {
        _audioSource.PlayOneShot(_sonidoMenu);
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
    public void ReproducirSonidoProfesiones()
    {
        _audioSource.PlayOneShot(_sonidoProfesiones);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoPracticar()
    {
        _audioSource.PlayOneShot(_sonidoPracticar);
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
