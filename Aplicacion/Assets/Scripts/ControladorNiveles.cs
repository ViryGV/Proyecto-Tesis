using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorNiveles : MonoBehaviour
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

    public void CargarPanelNivel()
    {
        Debug.Log("Cargar nivel");
        StartCoroutine(EsperarPanelCargando());
    }

    public void CargarMenuJuegos()
    {
        Debug.Log("Cargar nivel");
        StartCoroutine(EsperarPanelCargandoJuegos());
    }

    public IEnumerator EsperarPanelCargando()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("NivelesEmociones");
        Time.timeScale = 1;
    }

    public IEnumerator EsperarPanelCargandoJuegos()
    {
        panelCargando.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MenuJuegos");
        Time.timeScale = 1;
    }
}
