using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo para mostrar el
/// contenido de la profesión seleccionada
/// <list type="table">
/// <item>
/// <term>ActivarPanelDescripcion</term>
/// <description>Activa la vista a la explicación de lo que hace un veterinario</description>
/// </item>
/// <item>
/// <term>DesactivarPanelDescripcion</term>
/// <description>Desactiva la vista del panel para dar acceso a la segunda parte de la explicación</description>
/// </item>
/// <item>
/// <term>ActivarPanelDescripcionDos</term>
/// <description>Activa la vista con la continuación de la explicación de lo que hace un (profesión seleccionada)</description>
/// </item>
/// <item>
/// <term>DesactivarPanelDescripcionDos</term>
/// <description>Desactiva la vista del panel para dar acceso a la tercera parte de la explicación</description>
/// </item>
/// <item>
/// <term>ActivarPanelPorque</term>
/// <description>Activa la vista con la explicación de porque son (profesión seleccionada)</description>
/// </item>
/// <item>
/// <term>DesactivarPanelPorque</term>
/// <description>Desactiva la vista del panel para dar acceso a la cuarta parte de la explicación</description>
/// </item>
/// <item>
/// <term>ActivarPanelHerramientas</term>
/// <description>Activa la vista con algunos ejemplos del material que usan en (profesión seleccionada)</description>
/// </item>
/// <item>
/// <term>DesactivarPanelHerramientas</term>
/// <description>Desactiva la vista para dar acceso al panel final</description>
/// </item>
/// <item>
/// <term>ActivarPanelFinal</term>
/// <description>Activa la vista con un mensaje para alentar al usuario a investigar más</description>
/// </item>
/// <item>
/// <term>DesactivarPanelFinal</term>
/// <description>Desactiva la vista para dar acceso nuevamente al primer panel</description>
/// </item>
/// </list>
/// </summary>

public class ControladorEscenaProfesiones : MonoBehaviour
{
    /// <value>Establece el valor del panel que comenzará con la explicación</value>
    public GameObject panelIniciar;
    /// <value>Establece el valor del panel que continuará con la explicación</value>
    public GameObject panelDescripcion;
    /// <value>Establece el valor del panel que informa el motivo de porque escogieron esa profesión</value>
    public GameObject panelPorque;
    /// <value>Establece el valor del panel que contiene algunos ejemplo de las herramientas que
    /// utilizan para cumplir con su trabajo</value>
    public GameObject panelHerramientas;
    /// <value>Establece el valor del panel con un mensaje para alentar una investigación</value>
    public GameObject panelFinal;
    /// <value>Establece el valor para poder manipular el botón (desactivarlo)</value>
    public GameObject btnIniciar;
    /// <value>Establece el valor para poder manipular el botón (desactivarlo)</value>
    public GameObject btnMenu;
    /// <value>Establece el valor para poder manipular el botón (activarlo)</value>
    public GameObject btnFinalizar;
    /// <value>Establece el valor para poder manipular la imagen (desactivarlo)</value>
    public GameObject imageBuho;
    /// <value>Establece el valor para poder manipular la imagen (desactivarlo)</value>
    public GameObject imagedialogo;
    public TextMeshProUGUI dialogText;

    public void ActivarPanelDescripcion()
    {
        panelIniciar.SetActive(true);
        btnIniciar.SetActive(false);
        imageBuho.SetActive(false);
        imagedialogo.SetActive(false);
        dialogText.enabled = false;
        DesactivarPanelDescripcionDos();
        DesactivarPanelFinal();
    }

    public void DesactivarPanelDescripcion()
    {
        panelIniciar.SetActive(false);
    }

    public void ActivarPanelDescripcionDos()
    {
        DesactivarPanelDescripcion();
        DesactivarPanelPorque();
        panelDescripcion.SetActive(true);
    }

    public void DesactivarPanelDescripcionDos()
    {
        panelDescripcion.SetActive(false);
    }

    public void ActivarPanelPorque()
    {
        DesactivarPanelDescripcionDos();
        DesactivarPanelHerramientas();
        panelPorque.SetActive(true);
    }

    public void DesactivarPanelPorque()
    {
        panelPorque.SetActive(false);
    }

    public void ActivarPanelHerramientas()
    {
        DesactivarPanelPorque();
        panelHerramientas.SetActive(true);
    }

    public void DesactivarPanelHerramientas()
    {
        panelHerramientas.SetActive(false);
    }

    public void ActivarPanelFinal()
    {
        DesactivarPanelHerramientas();
        panelFinal.SetActive(true);
        btnFinalizar.SetActive(true);
        btnMenu.SetActive(false);
    }

    public void DesactivarPanelFinal()
    {
        panelFinal.SetActive(false);
        btnFinalizar.SetActive(false);
        btnMenu.SetActive(true);
    }
}
