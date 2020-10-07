using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonesProfesiones : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoVeterinario;
    [SerializeField]
    private AudioClip _sonidoBombero;
    [SerializeField]
    private AudioClip _sonidoRegresar;
    [SerializeField]
    private AudioClip _sonidoInicio;
    [SerializeField]
    private AudioClip _sonidoStart;
    [SerializeField]
    private AudioClip _sonidoSiguiente;
    [SerializeField]
    private AudioClip _sonidoAnterior;
    [SerializeField]
    private AudioClip _sonidoTerminar;
    [SerializeField]
    private AudioClip _sonidoReiniciar;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoVeterinario()
    {
        _audioSource.PlayOneShot(_sonidoVeterinario);
    }

    public void ReproducirSonidoBombero()
    {
        _audioSource.PlayOneShot(_sonidoBombero);
    }

    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }

    public void ReproducirSonidoInicio()
    {
        _audioSource.PlayOneShot(_sonidoInicio);
    }

    public void ReproducirSonidoStart()
    {
        _audioSource.PlayOneShot(_sonidoStart);
    }

    public void ReproducirSonidoSiguiente()
    {
        _audioSource.PlayOneShot(_sonidoSiguiente);
    }

    public void ReproducirSonidoAnterior()
    {
        _audioSource.PlayOneShot(_sonidoAnterior);
    }

    public void ReproducirSonidoReiniciar()
    {
        _audioSource.PlayOneShot(_sonidoReiniciar);
    }

    public void ReproducirSonidoTerminar()
    {
        _audioSource.PlayOneShot(_sonidoTerminar);
    }
}
