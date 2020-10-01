using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo que permite cerrar la aplicación
/// en su totalidad
/// </summary>
public class CerrarJuego : MonoBehaviour
{
    /// <summary>
    /// Método que se encarga de cerrar la aplicación
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
