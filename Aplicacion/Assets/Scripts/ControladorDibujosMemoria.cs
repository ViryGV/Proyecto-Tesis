using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el tiempo de vida de las imagenes
/// de los niveles 1 y 3 de memoria
/// </summary>
public class ControladorDibujosMemoria : MonoBehaviour
{
    /// <value>Establece el valor flotante del tiempo de vida que tiene en pantalla los cuadros de diálogo</value>
    public float tiempoVida;

    /// <value>Establece el valor para poder manipular la interacción del botón</value>
    public Button empezar_btn;
    /// <value>Establece el valor para el panel que contendrá las preguntas </value>
    public GameObject panel;

    // Update is called once per frame
    /// <summary>
    /// Actualiza los valores de las variables establecidas
    /// </summary>
    void Update()
    {
        tiempoVida -= Time.deltaTime;

        // Si el tiempo de vida es menor igual a cero 
        //el objeto (Cosmo) será destruido
        if (tiempoVida <= 0)
        {
            panel.SetActive(false);
            empezar_btn.interactable = true;
        }
    }
}