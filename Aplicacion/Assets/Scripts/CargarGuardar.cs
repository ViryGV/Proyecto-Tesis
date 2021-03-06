﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//compile with: -doc:DocFileName.xml

/// <summary>
/// Esta clase maneja el flujo de los niveles que han sido desbloqueados
/// generando un archivo donde se guarda esa información y posteriormente
/// se podrá volver a accer a esta cuando se inice la aplicación
/// </summary>
public class CargarGuardar : MonoBehaviour
{
    /// <value>Establece un valor donde será almacenado el archivo para guardar los datos</value>
    private string _rutaArchivo;

    /// <value>Establece un valor estático para saber si el archivo existe o no</value>
    static bool existe = true;

    /// <summary>
    /// Permite buscar el archivo cuando la aplicación se inicia por primera vez
    /// </summary>
    void Awake()
    {
        _rutaArchivo = Application.persistentDataPath + "/datos.dat";
        // Si el archivo ya existe carga la información
        // de los niveles que se han superado
        if (existe)
        {
            Cargar();
            existe = false;
        }
    }

    /// <summary>
    /// Método que almacena la información en el archivo de los niveles que se
    /// han superado
    /// </summary>
    public void Guardar()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(_rutaArchivo);
        GuardarDatos datos = new GuardarDatos(ControladorJuego.nivelesDisponibles, ControladorJuego.nivelesDisponiblesAtencion, ControladorJuego.nivelesDisponiblesComedor, 
                                                ControladorJuego.nivelesDisponiblesUrbanidad, ControladorJuego.nivelesDisponiblesMemoria, ControladorJuego.nivelesDisponiblesEscuela,
                                                ControladorJuego.nivelesDisponiblesSumar);
        bf.Serialize(file, datos);
        file.Close();
    }

    /// <summary>
    /// Método que se encarga de mostrar los niveles que fueron superados
    /// permitiendolé al usuario volver a entrar en ellos
    /// </summary>
    public void Cargar()
    {
        if (File.Exists(_rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(_rutaArchivo, FileMode.Open);
            GuardarDatos datos = (GuardarDatos)bf.Deserialize(file);
            ControladorJuego.nivelesDisponibles = datos.nivelesDesbloqueados;
            ControladorJuego.nivelesDisponiblesAtencion = datos.nivelesDesbloqueadosAtencion;
            ControladorJuego.nivelesDisponiblesComedor = datos.nivelesDesbloqueadosComedor;
            ControladorJuego.nivelesDisponiblesUrbanidad = datos.nivelesDesbloqueadosUrbanidad;
            ControladorJuego.nivelesDisponiblesEscuela = datos.nivelesDesbloqueadosEscuela;
            ControladorJuego.nivelesDisponiblesMemoria = datos.nivelesDesbloqueadosMemoria;
            ControladorJuego.nivelesDisponiblesSumar = datos.nivelesDesbloqueadosSumar;
        }
        else
        {
            ControladorJuego.nivelesDisponibles = 0;
            ControladorJuego.nivelesDisponiblesAtencion = 0;
            ControladorJuego.nivelesDisponiblesComedor = 0;
            ControladorJuego.nivelesDisponiblesUrbanidad = 0;
            ControladorJuego.nivelesDisponiblesEscuela = 0;
            ControladorJuego.nivelesDisponiblesMemoria = 0;
            ControladorJuego.nivelesDisponiblesSumar = 0;
        }
    }
}

/// <summary>
/// Esta clase maneja el flujo de los datos de los
/// niveles (superados) que serán guardados en la memoria
/// </summary>
[System.Serializable]
class GuardarDatos
{
    /// <value>Establece un valor para los niveles que han sido desbloqueados (emociones)</value>
    public int nivelesDesbloqueados;
    /// <value>Establece un valor para los niveles que han sido desbloqueados</value>
    public int nivelesDesbloqueadosAtencion;
    /// <value>Establece un valor para los niveles que han sido desbloqueados</value>
    public int nivelesDesbloqueadosComedor;
    /// <value>Establece un valor para los niveles que han sido desbloqueados</value>
    public int nivelesDesbloqueadosUrbanidad;
    /// <value>Establece un valor para los niveles que han sido desbloqueados</value>
    public int nivelesDesbloqueadosEscuela;
    /// <value>Establece un valor para los niveles que han sido desbloqueados</value>
    public int nivelesDesbloqueadosMemoria;
    /// <value>Establece un valor para los niveles que han sido desbloqueados</value>
    public int nivelesDesbloqueadosSumar;

    /// <summary>Este método de guardar la información en memoria
    /// de los niveles que desbloqueo el usuario</summary>
    /// <param name="nivelDes">El valor del nivel(es) desbloqueado en la parte de emociones</param>
    /// <param name="nivelADes">El valor del nivel(es) desbloqueado en la parte de atención</param>
    /// <param name="nivelDesComedor">El valor del nivel(es) desbloqueado en la parte de instrucciones (REGLAS COMEDOR)</param>
    /// <param name="nivelDesUrbanidad">El valor del nivel(es) desbloqueado en la parte de instrucciones (REGLAS SOCIALES)</param>
    /// <param name="nivelDesEscuela">El valor del nivel(es) desbloqueado en la parte de instrucciones (REGLAS CLASE)</param>
    /// <param name="nivelDesMemoria">El valor del nivel(es) desbloqueado en la parte de memoria de trabajo</param>
    /// <param name="nivelDesSunar">El valor del nivel(es) desbloqueado en la parte de razonamiento matemático (SUMAR)</param>
    public GuardarDatos(int nivelesDes, int nivelesADes, int nivelesDesComedor, int nivelDesUrbanidad, int nivelDesMemoria, int nivelDesEscuela, int nivelDesSumar)
    {
        nivelesDesbloqueados = nivelesDes;
        nivelesDesbloqueadosAtencion = nivelesADes;
        nivelesDesbloqueadosComedor = nivelesDesComedor;
        nivelesDesbloqueadosUrbanidad = nivelDesUrbanidad;
        nivelesDesbloqueadosEscuela = nivelDesEscuela;
        nivelesDesbloqueadosMemoria = nivelDesMemoria;
        nivelesDesbloqueadosSumar = nivelDesSumar;
    }
}