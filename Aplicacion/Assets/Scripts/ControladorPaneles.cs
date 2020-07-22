using System.Collections;
using System.Collections.Generic;
using UnityEngine;


///<summary>
///Clase cuya función es controlar el flujo entre los distintos paneles (menús) dispuestos para la aplicación
///<para>Permite la navegación entre las opciones existentes</para>
///</summary>
///<list type="table">
///<item>
///<term>ActivarPanelPrincipal</term>
///<description>Activa la vista de las opciones y funciones principlaes</description>
///<item>
///<term>DesactivarPanelPrincipal</term>
///<description>Desactiva la vista de las opciones y funciones principlaes para dar acceso a otro panel</description>
///<term>ActivarPanelJuegos</term>
///<description>Activa la vista de las opciones para las actividades (Historias, Practicar, Profesiones y Juegos)</description>
///<item>
///<term>DesactivarPanelJuegos</term>
///<description>Desactiva la vista del panel para dar acceso a otro panel o al panel principal</description>
///<item>
///<term>ActivarPanelOpciones</term>
///<description>Activa la vista de las opciones de la aplicación</description>
///<item>
///<term>DesactivarPanelOpciones</term>
///<description>Desactiva la vista de las opciones para dar acceso al panel principal</description>
///<item>
///<term>ActivarPanelInfo</term>
///<description>Activa la vista del panel de información donde se describe a la aplicación, su desarrollador y contribuciones</description>
///<item>
///<term>DesactivarPanelInfo</term>
///<description>Desactiva la vista de la información para dar acceso al panel principal</description>
///<item>
///<term>ActivarPanelSalir</term>
///<description>Activa la vista para la opción de salir (cerrar la aplicación)</description>
///<item>
///<term>DesactivarPanelSalir</term>
///<description>Desactiva la vista de salir para dar acceso al panel principal o cerrar la aplicación</description>
///<item>
///<term>ActivarPanelProgreso</term>
///<description>Activa la vista para ver el progreso de los niños</description>
///<item>
///<term>DesactivarPanelProgreso</term>
///<description>Desactiva la vista de progreso para dar acceso al panel principal</description>
public class ControladorPaneles : MonoBehaviour
{
    public GameObject panelPrincipal;
    public GameObject panelSalir;
    public GameObject panelInfo;
    public GameObject panelOpciones;
    public GameObject panelProgreso;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPanelPrincipal()
    {
        panelPrincipal.SetActive (true);
    }

    public void DesactivarPanelPrincipal()
    {
        panelPrincipal.SetActive(false);
    }

    public void ActivarPanelOpciones() //Personajes
    {
        panelOpciones.SetActive(true);
        //panelPrincipal.SetActive(false);
    }

    public void DesactivarPanelOpciones()
    {
        panelPrincipal.SetActive(true);
        panelOpciones.SetActive(false);
    }

    public void ActivarPanelInfo()
    {
        panelInfo.SetActive(true);
        //panelPrincipal.SetActive(false);
    }

    public void DesactivarPanelInfo()
    {
        panelPrincipal.SetActive(true);
        panelInfo.SetActive(false);
    }

    public void ActivarPanelSalir()
    {
        panelSalir.SetActive(true);
        //panelPrincipal.SetActive(false);
    }

    public void DesactivarPanelSalir()
    {
        panelPrincipal.SetActive(true);
        panelSalir.SetActive(false);
    }

    public void ActivarPanelProgreso()
    {
        panelProgreso.SetActive(true);
    }

    public void DesactivarPanelProgreso()
    {
        panelPrincipal.SetActive(true);
        panelProgreso.SetActive(false);
    }
}
