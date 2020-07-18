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
///<item>
///<term>ActivarPanelActividades</term>
///<description>Activa la vista de las actividades recompiladas en base a estrategias</description>
///<item>
///<term>DesactivarPanelActiviades</term>
///<description>Desactiva la vista de las activadades para dar acceso al panel de juegos</description>
///<item>
///<term>DesactivarPanelActividadesJuegos</term>
///<description>Desactiva la vista de juegos para dar acceso al panel principal</description>
///<item>
///<term>ActivarPanelHistorias</term>
///<description>Activa la vista de algunas historias donde el niño puede seleccionar una respuesta ante la situación presentada</description>
///<item>
///<term>DesactivarPanelHistorias</term>
///<description>Desactiva la vista de las historias para dar acceso al panel de juegos</description>
///<item>
///<term>DesactivarPanelHistoriasJuegos</term>
///<description>Desactiva la vista de juegos para dar acceso al panel principal</description>
///<item>
///<term>ActivarPanelProfesiones</term>
///<description>Activa la vista de algunas profesiones u oficios donde se le permita al niño generar interés por otros temas</description>
///<item>
///<term>DesactivarPanelProfesiones</term>
///<description>Desactiva la vista de las profesioes y oficios para dar acceso al panel de juegos</description>
///<item>
///<term>DesactivarPanelProfesionesJuegos</term>
///<description>Desactiva la vista de juegos para dar acceso al panel principal</description>
///<item>
///<term>ActivarPanelMatematicas</term>
///<description>Activa la vista que le permite al niño poner en práctica sus hábilidades y conocimiento en el área de matemáticas</description>
///<item>
///<term>DesactivarPanelMatematicas</term>
///<description>Desactiva la vista de matemáticas para dar acceso al panel de juegos</description>
///<item>
///<term>DesactivarPanelMatematicasJuegos</term>
///<description>Desactiva la vista de juegos para dar acceso al panel principal</description>
public class ControladorPaneles : MonoBehaviour
{
    public GameObject panelPrincipal;
    public GameObject panelJuegos;
    public GameObject panelSalir;
    public GameObject panelInfo;
    public GameObject panelOpciones;
    public GameObject panelActividades;
    public GameObject panelHistorias;
    public GameObject panelProgreso;
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

    public void ActivarPanelPrincipal()
    {
        panelPrincipal.SetActive (true);
        panelJuegos.SetActive(false); //Mundos
    }

    public void DesactivarPanelPrincipal()
    {
        panelPrincipal.SetActive(false);
    }

    public void ActivarPanelJuegos()
    {
        panelJuegos.SetActive(true);
        //panelPrincipal.SetActive(false);
    }

    public void DesactivarPanelJuegos()
    {
        panelPrincipal.SetActive(true);
        panelJuegos.SetActive(false);
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

    public void ActivarPanelActividades()
    {
        panelActividades.SetActive(true);
    }

    public void DesactivarPanelActividades()
    {
        panelJuegos.SetActive(true);
        panelActividades.SetActive(false);
    }

    public void DesactivarPanelActividadesJuegos()
    {
        panelPrincipal.SetActive(true);
        panelActividades.SetActive(false);
        panelJuegos.SetActive(false);
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

    public void DesactivarPanelHistoriasJuegos()
    {
        panelPrincipal.SetActive(true);
        panelHistorias.SetActive(false);
        panelJuegos.SetActive(false);
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

    public void DesactivarPanelProfesionesJuegos()
    {
        panelPrincipal.SetActive(true);
        panelProfesiones.SetActive(false);
        panelJuegos.SetActive(false);
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

    public void DesactivarPanelMatematicasJuegos()
    {
        panelPrincipal.SetActive(true);
        panelMatematicas.SetActive(false);
        panelJuegos.SetActive(false);
    }
}
