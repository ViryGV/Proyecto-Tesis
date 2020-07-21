using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorDialogo : MonoBehaviour
{
    public TextMeshProUGUI textoDisplay;
    public GameObject botonContinuar;
    public GameObject objetoUno;
    public GameObject emocionT;
    public GameObject emocionA;
    public GameObject emocionE;
    public GameObject emocionTemor;
    public GameObject textoPregunta;

    private AudioSource _audio;

    Renderer render;

    public string[] palabras;
    public float typingSpeed;

    private int _index;

    void Start()
    {
        //_audio = GetComponent<AudioSource>();
        render = objetoUno.GetComponent<Renderer>();
        StartCoroutine(Type());
    }

    void Update()
    {
        if (textoDisplay.text == palabras[_index])
        {
            botonContinuar.SetActive(true);
        }
    }
    
    IEnumerator Type()
    {
        foreach (char letras in palabras[_index].ToCharArray())
        {
            textoDisplay.text += letras;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        //_audio.Play();
        botonContinuar.SetActive(false);
        emocionA.SetActive(false);
        emocionE.SetActive(false);
        emocionT.SetActive(false);
        emocionTemor.SetActive(false);
        textoPregunta.SetActive(false);

        if (_index < palabras.Length - 1)
        {
            _index++;
            textoDisplay.text = "";
            StartCoroutine(Type());
            render.enabled = false;
        }
        else
        {
            textoDisplay.text = "";
            botonContinuar.SetActive(false);
            render.enabled = true;
            emocionA.SetActive(true);
            emocionE.SetActive(true);
            emocionT.SetActive(true);
            emocionTemor.SetActive(true);
            textoPregunta.SetActive(true);
        }
    }
}
