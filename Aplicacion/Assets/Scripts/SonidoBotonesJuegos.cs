using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotonesJuegos : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoActividades;
    [SerializeField]
    private AudioClip _sonidoRegresar;
    [SerializeField]
    private AudioClip _sonidoMenu;
    [SerializeField]
    private AudioClip _sonidoHistorias;
    [SerializeField]
    private AudioClip _sonidoProfesiones;
    [SerializeField]
    private AudioClip _sonidoPracticar;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoActividades()
    {
        _audioSource.PlayOneShot(_sonidoActividades);
    }

    public void ReproducirSonidoMenu()
    {
        _audioSource.PlayOneShot(_sonidoMenu);
    }

    public void ReproducirSonidoHistorias()
    {
        _audioSource.PlayOneShot(_sonidoHistorias);
    }

    public void ReproducirSonidoProfesiones()
    {
        _audioSource.PlayOneShot(_sonidoProfesiones);
    }

    public void ReproducirSonidoPracticar()
    {
        _audioSource.PlayOneShot(_sonidoPracticar);
    }

    public void ReproducirSonidoRegresar()
    {
        _audioSource.PlayOneShot(_sonidoRegresar);
    }
}
