using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el tiempo de vida del personaje Cosmo
/// </summary>
public class ControladorDibujosMemoria : MonoBehaviour
{
    /// <value>Establece el valor flotante del tiempo de vida que tiene en pantalla los cuadros de diálogo</value>
    public float tiempoVida;

    /// <value>Arreglo de botones para poder desbloquearlos cuando la posición cambie</value>
    public Button empezar_btn;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Awake()
    {
        
    }

    // Update is called once per frame
    // Update is called once per frame
    /// <summary>
    /// Actualiza los valores de las variables establecidas
    /// </summary>
    void Update()
    {
        tiempoVida -= Time.deltaTime;
        //_audio.Play();
        // Si el tiempo de vida es menor igual a cero 
        //el objeto (Cosmo) será destruido
        if (tiempoVida <= 0)
        {
            panel.SetActive(false);
            empezar_btn.interactable = true;
        }
    }
}