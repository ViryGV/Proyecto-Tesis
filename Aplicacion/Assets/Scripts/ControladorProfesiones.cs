using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//compile with: -doc:DocFileName.xml

public class ControladorProfesiones : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla de espera</value>
    public GameObject panelCargando;

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para el menú de historias
    /// </summary>
    public void CargarMenuProfesionesOficios()
    {
        StartCoroutine(EsperarPanelCargandoMenuProfesionesOficios());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y el menú de historias
    /// </summary>
    public IEnumerator EsperarPanelCargandoMenuProfesionesOficios()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuProfesiones");
        Time.timeScale = 1;
    }

    /// <summary>
    /// Activa la corrutina para cargar la pantalla de espera para los veterinarios
    /// </summary>
    public void CargarVeterinarios()
    {
        StartCoroutine(EsperarPanelCargandoVeterinarios());
    }

    /// <summary>
    /// Permite crear una corrutina entre el lapso de tiempo en que
    /// se muestran la pantalla de cargando y la opción de veterinarios
    /// </summary>
    public IEnumerator EsperarPanelCargandoVeterinarios()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Veterinario");
        Time.timeScale = 1;
    }
}
