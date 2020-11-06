using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo que permite modificar
/// las configuraciones de la aplicación al gusto del usuario
/// </summary>
public class MenuOpciones : MonoBehaviour
{
    [SerializeField] Slider volumenSlider;

    public void Awake()
    {
        if (PlayerPrefs.HasKey("Volumen"))
        {
            ControlarVolumen(PlayerPrefs.GetFloat("Volumen"));
            volumenSlider.value = PlayerPrefs.GetFloat("Volumen");
        }
    }

    public void ControlarVolumen(float volumen)
    {
        AudioListener.volume = volumen;
        PlayerPrefs.SetFloat("Volumen", volumen);
    }
}
