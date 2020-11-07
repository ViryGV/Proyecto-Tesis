using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo entre el menú principal y el menú
/// para el razonamiento matemático
/// </summary>
public class ControladorMenuMatematicas : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla de espera</value>
    public GameObject panelCargando;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para el menú de
    /// razonamiento matemático
    /// </summary>
    public void CargarPracticar()
    {
        StartCoroutine(EsperarPanelCargando());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de razonamiento matemático
    /// </summary>
    public IEnumerator EsperarPanelCargando()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuMatematicas");
        Time.timeScale = 1;
    }
}
