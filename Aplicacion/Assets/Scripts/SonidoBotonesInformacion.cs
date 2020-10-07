using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonesInformacion : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoActividades;
    [SerializeField]
    private AudioClip _sonidoRegresar;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoActividades()
    {
        _audioSource.PlayOneShot(_sonidoActividades);
    }

    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }
}
