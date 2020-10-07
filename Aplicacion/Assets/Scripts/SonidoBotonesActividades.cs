using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonesActividades : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoEmociones;
    [SerializeField]
    private AudioClip _sonidoAtencion;
    [SerializeField]
    private AudioClip _sonidoMemoria;
    [SerializeField]
    private AudioClip _sonidoInstrucciones;
    [SerializeField]
    /*private AudioClip _sonidoCerrar;
    [SerializeField]
    private AudioClip _sonidoRegresar;
    [SerializeField]
    private AudioClip _sonidoProgreso;*/

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoEmociones()
    {
        _audioSource.PlayOneShot(_sonidoEmociones);
    }

    public void ReproducirSonidoAtencion()
    {
        _audioSource.PlayOneShot(_sonidoAtencion);
    }

    public void ReproducirSonidoInstrucciones()
    {
        _audioSource.PlayOneShot(_sonidoInstrucciones);
    }

    public void ReproducirSonidoMemoria()
    {
        _audioSource.PlayOneShot(_sonidoMemoria);
    }

    /*public void ReproducirSonidoProgreso()
    {
        _audioSource.PlayOneShot(_sonidoProgreso);
    }

    public void ReproducirSonidoCerrar()
    {
        _audioSource.PlayOneShot(_sonidoCerrar);
    }

    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }*/
}
