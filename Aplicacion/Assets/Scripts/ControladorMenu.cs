using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{
    public GameObject panelCargando;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CargarMenu()
    {
        Debug.Log("Cargar nivel");
        StartCoroutine(EsperarPanelCargando());
    }

    public IEnumerator EsperarPanelCargando()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void CargarMenuJuegos()
    {
        Debug.Log("Cargar nivel");
        StartCoroutine(EsperarPanelCargandoJuegos());
    }

    public IEnumerator EsperarPanelCargandoJuegos()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuJuegos");
        Time.timeScale = 1;
    }
}
