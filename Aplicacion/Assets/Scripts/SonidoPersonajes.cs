using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPersonajes : MonoBehaviour
{
    private AudioSource _audioSource;

    [SerializeField]
    private AudioClip _sonidoCosmo;
    [SerializeField]
    private AudioClip _sonidoTobi;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoCosmo()
    {
        _audioSource.PlayOneShot(_sonidoCosmo);
    }

    public void ReproducirSonidoTobi()
    {
        _audioSource.PlayOneShot(_sonidoTobi);
    }
}
