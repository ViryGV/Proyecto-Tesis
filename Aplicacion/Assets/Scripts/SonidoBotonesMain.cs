using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonesMain : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoJugar;
    [SerializeField]
    private AudioClip _sonidoOpciones;
    [SerializeField]
    private AudioClip _sonidoSalir;
    [SerializeField]
    private AudioClip _sonidoInfo;
    [SerializeField]
    private AudioClip _sonidoCerrar;
    [SerializeField]
    private AudioClip _sonidoRegresar;
    [SerializeField]
    private AudioClip _sonidoProgreso;
    [SerializeField]
    private AudioClip _sonidoEliminar;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoJugar()
    {
        _audioSource.PlayOneShot(_sonidoJugar);
    }

    public void ReproducirSonidoOpciones()
    {
        _audioSource.PlayOneShot(_sonidoOpciones);
    }

    public void ReproducirSonidoInfo()
    {
        _audioSource.PlayOneShot(_sonidoInfo);
    }

    public void ReproducirSonidoSalir()
    {
        _audioSource.PlayOneShot(_sonidoSalir);
    }

    public void ReproducirSonidoProgreso()
    {
        _audioSource.PlayOneShot(_sonidoProgreso);
    }

    public void ReproducirSonidoCerrar()
    {
        _audioSource.PlayOneShot(_sonidoCerrar);
    }

    public void ReproducirSonidoEliminar()
    {
        _audioSource.PlayOneShot(_sonidoEliminar);
    }

    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }
}
