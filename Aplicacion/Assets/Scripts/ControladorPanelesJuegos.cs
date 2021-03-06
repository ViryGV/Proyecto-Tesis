﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Clase cuya función es controlar el flujo entre los distintos paneles (menús) dispuestos para la aplicación
/// <para>Permite la navegación entre las opciones existentes</para>
/// <list type="table">
/// <item>
/// <term>ActivarPanelJuegos</term>
/// <description>Activa la vista de las opciones para las actividades (Historias, Practicar, Profesiones y Juegos)</description>
/// </item>
/// <item>
/// <term>DesactivarPanelJuegos</term>
/// <description>Desactiva la vista del panel para dar acceso a otro panel o al panel principal</description>
/// </item>
/// <item>
/// <term>ActivarPanelActividades</term>
/// <description>Activa la vista de las actividades recompiladas en base a estrategias</description>
/// </item>
/// <item>
/// <term>DesactivarPanelActiviades</term>
/// <description>Desactiva la vista de las activadades para dar acceso al panel de juegos</description>
/// </item>
/// <item>
/// <term>ActivarPanelMatematicas</term>
/// <description>Activa la vista que le permite al niño poner en práctica sus hábilidades y conocimiento en el área de matemáticas</description>
/// </item>
/// <item>
/// <term>DesactivarPanelMatematicas</term>
/// <description>Desactiva la vista de matemáticas para dar acceso al panel de juegos</description>
/// </item>
/// <item>
/// <term>ActivarPanelReglas</term>
/// <description>Activa la vista que le permite al niño seleccionar alguna regla social para poner en práctica</description>
/// </item>
/// <item>
/// <term>DesactivarPanelMatematicas</term>
/// <description>Desactiva la vista de reglas para dar acceso al panel de juegos</description>
/// </item>
/// </list>
/// </summary>
public class ControladorPanelesJuegos : MonoBehaviour
{
    /// <value>Establece el valor del panel que contendrá la pantalla de Juegos</value>
    public GameObject panelJuegos;
    /// <value>Establece el valor del panel que contendrá la pantalla de las tarjetas/value>
    public GameObject panelActividades;
    /// <value>Establece el valor del panel que contendrá la pantalla del razonamiento matemático</value>
    public GameObject panelMatematicas;
    /// <value>Establece el valor del panel que contendrá la pantalla de las opciones 
    /// de la tarjeta instrucciones visuales</value>
    public GameObject panelReglas;

    public void ActivarPanelJuegos()
    {
        panelJuegos.SetActive(true);
    }
    public void DesactivarPanelJuegos()
    {
        panelJuegos.SetActive(false);
    }

    public void ActivarPanelActividades()
    {
        panelActividades.SetActive(true);
    }

    public void DesactivarPanelActividades()
    {
        panelJuegos.SetActive(true);
        panelActividades.SetActive(false);
    }

    public void ActivarPanelMatematicas()
    {
        panelMatematicas.SetActive(true);
    }

    public void DesactivarPanelMatematicas()
    {
        panelJuegos.SetActive(true);
        panelMatematicas.SetActive(false);
    }

    public void ActivarPanelReglas()
    {
        panelReglas.SetActive(true);
    }

    public void DesactivarPanelReglas()
    {
        panelActividades.SetActive(true);
        panelReglas.SetActive(false);
    }
}