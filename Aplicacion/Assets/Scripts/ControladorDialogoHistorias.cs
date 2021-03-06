﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo de las conversaciones de Tobi
/// Y maneja cuando aparecen los objetos del nivel
/// </summary>
public class ControladorDialogoHistorias : MonoBehaviour
{
    /// <value>Establece el valor del texto que será mostrado en pantalla</value>
    public TextMeshProUGUI textoDisplay;
    /// <value>Establece el valor para poder seguir avanzando en la conversación</value>
    public GameObject botonContinuar;
    /// <summary>
    /// <list type="bullet">
    /// <item>
    /// <term>textoPregunta</term>
    /// <description>Texto indicativo donde irá la pregunta</description>
    /// </item>
    /// <item>
    /// <term>textoAciertos</term>
    /// <description>Texto indicativo donde se irán mostrando el valor de aciertos</description>
    /// </item>
    /// </list>
    /// </summary>
    public GameObject panelPregunta;
    public GameObject panelHistoria;

    /// <value>Crea un arreglo para las sentencias del diálogo</value>
    public string[] palabras;
    /// <value>Establece el valor de la velocidad en el que cargan las oraciones</value>
    public float typingSpeed;

    /// <value>Permite conocer la posición de las palabras</value>
    private int _index;

    /// <summary>
    /// Inicializa las variables establecidas
    /// </summary>
    void Start()
    {
        StartCoroutine(Type());
    }

    /// <summary>
    /// Actualiza los valores de las variables establecidas
    /// </summary>
    void Update()
    {
        // Si el texto mostrado en pantalla es igual a la posición 
        // de las palabras en el arreglo,
        // el botón para continuar la conversación se activa
        if (textoDisplay.text == palabras[_index])
        {
            botonContinuar.SetActive(true);
        }
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran el diálogo actual y el nuevo diálogo a mostrar
    /// </summary>
    /// <remarks>
    /// Mediante el foreach se recorren las palabras de la oración 
    /// que se esta llevando a cabo
    /// </remarks>
    IEnumerator Type()
    {
        foreach (char letras in palabras[_index].ToCharArray())
        {
            textoDisplay.text += letras;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    /// <summary>
    /// Actualiza la conversación a la siguiente oración
    /// </summary>
    public void NextSentence()
    {
        botonContinuar.SetActive(false);
        panelPregunta.SetActive(false);

        // Si el índice de las palabras es menor al tamaño de ellas 
        // se incrementa un valor, los objetos permanecen desabilitados
        // y se llama a la corrutina
        // De lo contrario se desactiva el botón para continuar el diálogo
        // y se habilita el resto de los componentes
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
            panelPregunta.SetActive(true);
            panelHistoria.SetActive(false);
        }
    }
}
