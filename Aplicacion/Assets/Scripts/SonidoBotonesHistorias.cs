using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonesHistorias : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoHistorias;
    [SerializeField]
    private AudioClip _sonidoRegresar;
    [SerializeField]
    private AudioClip _sonidoInicio;
    [SerializeField]
    private AudioClip _sonidoVolver;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoHistorias()
    {
        _audioSource.PlayOneShot(_sonidoHistorias);
    }

    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }

    public void ReproducirSonidoInicio()
    {
        _audioSource.PlayOneShot(_sonidoInicio);
    }

    public void ReproducirSonidoVolver()
    {
        _audioSource.PlayOneShot(_sonidoVolver);
    }
}
