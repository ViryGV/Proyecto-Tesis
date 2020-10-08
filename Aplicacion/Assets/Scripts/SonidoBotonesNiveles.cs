using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonesNiveles : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoNivelUno;
    [SerializeField]
    private AudioClip _sonidoNivelDos;
    [SerializeField]
    private AudioClip _sonidoNivelTres;
    [SerializeField]
    private AudioClip _sonidoRegresar;
    [SerializeField]
    private AudioClip _sonidoVolverN;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoNivelUno()
    {
        _audioSource.PlayOneShot(_sonidoNivelUno);
    }

    public void ReproducirSonidoNivelDos()
    {
        _audioSource.PlayOneShot(_sonidoNivelDos);
    }

    public void ReproducirSonidoNivelTres()
    {
        _audioSource.PlayOneShot(_sonidoNivelTres);
    }

    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }

    public void ReproducirSonidoRegresarNiveles()
    {
        _audioSource.PlayOneShot(_sonidoVolverN);
    }
}
