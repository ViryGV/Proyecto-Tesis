using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonesReglas : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoComedor;
    [SerializeField]
    private AudioClip _sonidoEscuela;
    [SerializeField]
    private AudioClip _sonidoUrbanidad;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoComedor()
    {
        _audioSource.PlayOneShot(_sonidoComedor);
    }

    public void ReproducirSonidoEscuela()
    {
        _audioSource.PlayOneShot(_sonidoEscuela);
    }

    public void ReproducirSonidoUrbanidad()
    {
        _audioSource.PlayOneShot(_sonidoUrbanidad);
    }
}
