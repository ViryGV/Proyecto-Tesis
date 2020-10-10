using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Clase cuya función es controlar el flujo entre los distintos paneles (menús) dispuestos para la aplicación
/// <para>Permite la navegación entre las opciones existentes</para>
/// <list type="table">
/// <item>
/// <term>ActivarPanelPrincipal</term>
/// <description>Activa la vista de las opciones y funciones principlaes</description>
/// </item>
/// <item>
/// <term>DesactivarPanelPrincipal</term>
/// <description>Desactiva la vista de las opciones y funciones principlaes para dar acceso a otro panel</description>
/// <item>
/// <term>ActivarPanelOpciones</term>
/// <description>Activa la vista de las opciones de la aplicación</description>
/// </item>
/// <item>
/// <term>DesactivarPanelOpciones</term>
/// <description>Desactiva la vista de las opciones para dar acceso al panel principal</description>
/// </item>
/// <item>
/// <term>ActivarPanelInfo</term>
/// <description>Activa la vista del panel de información donde se describe a la aplicación, su desarrollador y contribuciones</description>
/// </item>
/// <item>
/// <term>DesactivarPanelInfo</term>
/// <description>Desactiva la vista de la información para dar acceso al panel principal</description>
/// </item>
/// <item>
/// <term>ActivarPanelSalir</term>
/// <description>Activa la vista para la opción de salir (cerrar la aplicación)</description>
/// </item>
/// <item>
/// <term>DesactivarPanelSalir</term>
/// <description>Desactiva la vista de salir para dar acceso al panel principal o cerrar la aplicación</description>
/// </item>
/// </list>
/// </summary>
public class ControladorPaneles : MonoBehaviour
{
    /// <value>Almacena el valor que tendrá los elementos del panel principal</value>
    public GameObject panelPrincipal;
    /// <value>Almacena el valor que tendrá los elementos del panel salir del juego</value>
    public GameObject panelSalir;
    /// <value>Almacena el valor que tendrá los elementos del panel información/acerca de</value>
    public GameObject panelInfo;
    /// <value>Almacena el valor que tendrá los elementos del panelde opciones</value>
    public GameObject panelOpciones;

    public void ActivarPanelPrincipal()
    {
        panelPrincipal.SetActive (true);
    }

    public void DesactivarPanelPrincipal()
    {
        panelPrincipal.SetActive(false);
    }

    public void ActivarPanelOpciones()
    {
        panelOpciones.SetActive(true);
    }

    public void DesactivarPanelOpciones()
    {
        panelPrincipal.SetActive(true);
        panelOpciones.SetActive(false);
    }

    public void ActivarPanelInfo()
    {
        panelInfo.SetActive(true);
    }

    public void DesactivarPanelInfo()
    {
        panelPrincipal.SetActive(true);
        panelInfo.SetActive(false);
    }

    public void ActivarPanelSalir()
    {
        panelSalir.SetActive(true);
    }

    public void DesactivarPanelSalir()
    {
        panelPrincipal.SetActive(true);
        panelSalir.SetActive(false);
    }
}