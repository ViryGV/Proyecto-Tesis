﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para reproducir los sonidos
/// de los botones de los personajes de la aplicación
/// </summary>
public class SonidoPersonajes : MonoBehaviour
{
    /// <value>Variable privada que guarda el valor del recurso de sonido</value>
    private AudioSource _audioSource;

    /// <value>Variable serializada para almacenar el sonido del personaje de Cosmo</value>
    [SerializeField]
    private AudioClip _sonidoCosmo;
    /// <value>Variable serializada para almacenar el sonido del personaje de Tobi</value>
    [SerializeField]
    private AudioClip _sonidoTobi;
    /// <value>Variable serializada para almacenar el sonido del personaje de Penelope</value>
    [SerializeField]
    private AudioClip _sonidoPenelope;
    /// <value>Variable serializada para almacenar el sonido del personaje de Tadeo</value>
    [SerializeField]
    private AudioClip _sonidoTadeo;
    /// <value>Variable serializada para almacenar el sonido del personaje de Clarissa</value>
    [SerializeField]
    private AudioClip _sonidoClarissa;

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
    public void ReproducirSonidoCosmo()
    {
        _audioSource.PlayOneShot(_sonidoCosmo);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoTobi()
    {
        _audioSource.PlayOneShot(_sonidoTobi);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoPenelope()
    {
        _audioSource.PlayOneShot(_sonidoPenelope);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoTadeo()
    {
        _audioSource.PlayOneShot(_sonidoTadeo);
    }

    /// <summary>
    /// Método que se encarga de reconocer el botón al que se le
    /// asignó el sonido para poder reproducirlo cuando es accionado
    /// </summary>
    public void ReproducirSonidoClarissa()
    {
        _audioSource.PlayOneShot(_sonidoClarissa);
    }
}
