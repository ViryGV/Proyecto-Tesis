using System.Collections;
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
/// <term>ActivarPanelHistorias</term>
/// <description>Activa la vista de algunas historias donde el niño puede seleccionar una respuesta ante la situación presentada</description>
/// </item>
/// <item>
/// <term>DesactivarPanelHistorias</term>
/// <description>Desactiva la vista de las historias para dar acceso al panel de juegos</description>
/// </item>
/// <item>
/// <term>ActivarPanelProfesiones</term>
/// <description>Activa la vista de algunas profesiones u oficios donde se le permita al niño generar interés por otros temas</description>
/// </item>
/// <item>
/// <term>DesactivarPanelProfesiones</term>
/// <description>Desactiva la vista de las profesioes y oficios para dar acceso al panel de juegos</description>
/// </item>
/// <item>
/// <term>ActivarPanelMatematicas</term>
/// <description>Activa la vista que le permite al niño poner en práctica sus hábilidades y conocimiento en el área de matemáticas</description>
/// </item>
/// <item>
/// <term>DesactivarPanelMatematicas</term>
/// <description>Desactiva la vista de matemáticas para dar acceso al panel de juegos</description>
/// </item>
/// </list>
/// </summary>
public class ControladorPanelesJuegos : MonoBehaviour
{
    public GameObject panelJuegos;
    public GameObject panelActividades;
    public GameObject panelHistorias;
    public GameObject panelProfesiones;
    public GameObject panelMatematicas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

    public void ActivarPanelHistorias()
    {
        panelHistorias.SetActive(true);
    }

    public void DesactivarPanelHistorias()
    {
        panelJuegos.SetActive(true);
        panelHistorias.SetActive(false);
    }

    public void ActivarPanelProfesiones()
    {
        panelProfesiones.SetActive(true);
    }

    public void DesactivarPanelProfesiones()
    {
        panelJuegos.SetActive(true);
        panelProfesiones.SetActive(false);
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
}