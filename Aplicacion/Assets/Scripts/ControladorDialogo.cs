using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo de las conversaciones de Cosmo
/// Y maneja cuando aparecen los objetos del nivel
/// </summary>
public class ControladorDialogo : MonoBehaviour
{
    /// <value>Establece el valor del texto que será mostrado en pantalla</value>
    public TextMeshProUGUI textoDisplay;
    /// <value>Establece el valor para poder seguir avanzando en la conversación</value>
    public GameObject botonContinuar;
    /// <summary>
    /// <list type="bullet">
    /// <item>
    /// <term>objetoUno</term>
    /// <description>Addition Operation</description>
    /// </item>
    /// <item>
    /// <term>emocionT</term>
    /// <description>Texto indicativo de tristeza</description>
    /// </item>
    /// <item>
    /// <term>emocionA</term>
    /// <description>Texto indicativo de alegría</description>
    /// </item>
    /// <item>
    /// <term>emocionE</term>
    /// <description>Texto indicativo de enojo</description>
    /// </item>
    /// <item>
    /// <term>emocionTemor</term>
    /// <description>Texto indicativo de temor</description>
    /// </item>
    /// <item>
    /// <term>textoPregunta</term>
    /// <description>Texto indicativo donde irá la pregunta</description>
    /// </item>
    /// </list>
    /// </summary>
    public GameObject objetoUno;
    public GameObject emocionT;
    public GameObject emocionA;
    public GameObject emocionE;
    public GameObject emocionTemor;
    public GameObject textoPregunta;

    /// <value>Establece el valor para poner sonido en la conversación</value>
    private AudioSource _audio;

    /// <value>Acceder al valor de Renderer en los objetos para manipularlos</value>
    Renderer render;

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
        //_audio = GetComponent<AudioSource>();
        render = objetoUno.GetComponent<Renderer>();
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
        //_audio.Play();
        botonContinuar.SetActive(false);
        emocionA.SetActive(false);
        emocionE.SetActive(false);
        emocionT.SetActive(false);
        emocionTemor.SetActive(false);
        textoPregunta.SetActive(false);

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