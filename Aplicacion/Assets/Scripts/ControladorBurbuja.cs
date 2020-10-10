using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el tiempo de vida de los cuadros de diálogo
/// </summary>
public class ControladorBurbuja : MonoBehaviour
{
    /// <value>Establece el valor flotante del tiempo de vida que tiene en pantalla los cuadros de diálogo</value>
    public float tiempoVida;

    // Update is called once per frame
    /// <summary>
    /// Actualiza los valores de las variables establecidas
    /// </summary>
    void Update()
    {
        tiempoVida -= Time.deltaTime;
        // Si el tiempo de vida es menor igual a cero 
        //el objeto (cuadro de diálogo) será destruido
        if (tiempoVida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
