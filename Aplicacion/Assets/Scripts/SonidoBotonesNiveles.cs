using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones de los números de los niveles y los
/// botones de navegación del menú
/// </summary>
public class SonidoBotonesNiveles : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido de los botones que sean nivel uno</value>
    [SerializeField]
    private AudioClip _sonidoNivelUno;
    /// <value>Variable serializada para almacenar el sonido de los botones que sean nivel dos</value>
    [SerializeField]
    private AudioClip _sonidoNivelDos;
    /// <value>Variable serializada para almacenar el sonido de los botones que sean nivel tres</value>
    [SerializeField]
    private AudioClip _sonidoNivelTres;
    /// <value>Variable serializada para almacenar el sonido de los botón regresar (Menú Juegos)</value>
    [SerializeField]
    private AudioClip _sonidoRegresar;
    /// <value>Variable serializada para almacenar el sonido de los botón volver al menú de selección de niveles</value>
    [SerializeField]
    private AudioClip _sonidoVolverN;

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
    public void ReproducirSonidoRegresarNiveles()
    {
        _audioSource.PlayOneShot(_sonidoVolverN);
    }
}
