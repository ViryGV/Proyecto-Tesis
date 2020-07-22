using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorDialogoMenu : MonoBehaviour
{
    public TextMeshProUGUI textoDisplay;
    public GameObject botonContinuar;

    private AudioSource _audio;

    public string[] palabras;
    public float typingSpeed;

    private int _index;

    void Start()
    {
        //_audio = GetComponent<AudioSource>();
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

        if (_index < palabras.Length - 1)
        {
            _index++;
            textoDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textoDisplay.text = "";
            botonContinuar.SetActive(false);
        }
    }
}
