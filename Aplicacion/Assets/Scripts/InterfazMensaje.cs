using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InterfazMensaje : MonoBehaviour
{

    /* ---- Mostrar mensajes en pantalla por GameDevTraum ----
 * 
 * Esta solución consiste en el Script "InterfazDeUsuario" y el prefabricado "Solucion Mostrar Mensajes - GameDevTraum".
 * El Script "InterfazDeUsuario" provee tres métodos públicos para mostrar mensajes en pantalla.
 * 
 * InterfazDeUsuario.MostrarMensajeSimple(string mensaje)
 * 
 *      Muestra un mensaje por un frame, por lo tanto para que el mensaje se
 *      muestre de manera continua, debemos ejecutar ese método en cada frame que lo necesitemos. Esto puede servir para mostrar mensajes
 *      cuando el personaje se encuentra en determinado lugar o está mirando un objeto con el que se puede interactuar.
 * 
 * InterfazDeUsuario.MostrarMensajeSalteableTecla(string mensaje) 
 * 
 *      Se ejecuta una vez y muestra el mensaje en pantalla hasta que el
 *      jugador pulse cualquier tecla.
 * 
 * InterfazDeUsuario.MostrarMensajeSalteableBoton(string mensaje) 
 * 
 *      Se ejecuta una vez y muestra un mensaje hasta que el jugador
 *      pulse el botón "Entendido"
 * 
 * -------------------------------------------------------------------------------------------- *
 * Página: https://gamedevtraum.com/es/
 * Canal: https://youtube.com/c/GameDevTraum
 * Instagram: @gamedevtraum
 * 
 * Visita la página para encontrar más soluciones, Assets y artículos informativos
 * -------------------------------------------------------------------------------------------- *
 * 
 */

    #region CAMPOS
    [Header("Mensaje Salteable (botón)")]


    [SerializeField]
    private GameObject mensajeSalteableBotonObjeto; //Contenedor
    [SerializeField]
    private TextMeshProUGUI mensajeSalteableBotonTexto; //Objeto Texto
    private bool mensajeSalteableBotonActivo; //Estado del mensaje

    #endregion

    #region MÉTODOS


    void Start()
    {
        //mensajeSalteableBotonObjeto.SetActive(false);
    }


    private void OnGUI()
    {
        if (mensajeSalteableBotonActivo)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                LimpiarMensajeBoton();
            }
        }

        LimpiarMensajeBoton();
    }

    public void MostrarMensajeSalteableBoton(string mensaje)
    {
        mensajeSalteableBotonActivo = true;
        mensajeSalteableBotonTexto.text = mensaje;
        mensajeSalteableBotonObjeto.SetActive(true);
    }

    public void BotonSaltarMensaje()
    {
        if (mensajeSalteableBotonActivo)
        {
            LimpiarMensajeBoton();
        }
    }

    private void LimpiarMensajeBoton()
    {
        mensajeSalteableBotonActivo = false;
        mensajeSalteableBotonObjeto.SetActive(false);
    }

    #endregion

}
