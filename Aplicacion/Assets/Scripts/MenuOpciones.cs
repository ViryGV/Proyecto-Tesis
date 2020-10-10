using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo que permite modificar
/// las configuraciones de la aplicación al gusto del usuario
/// </summary>
public class MenuOpciones : MonoBehaviour
{
    public void SetVolume (float volumen)
    {
        Debug.Log(volumen);
    }
}
