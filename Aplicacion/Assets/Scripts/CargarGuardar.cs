using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class CargarGuardar : MonoBehaviour
{
    private string _rutaArchivo;

    static bool existe = true;

    void Awake()
    {
        _rutaArchivo = Application.persistentDataPath + "/datos.dat";
        if (existe)
        {
            Cargar();
            existe = false;
        }
    }

    public void Guardar()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(_rutaArchivo);
        GuardarDatos datos = new GuardarDatos(ControladorJuego.nivelesDisponibles);
        bf.Serialize(file, datos);
        file.Close();
    }

    public void Cargar()
    {
        if (File.Exists(_rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(_rutaArchivo, FileMode.Open);
            GuardarDatos datos = (GuardarDatos)bf.Deserialize(file);
            ControladorJuego.nivelesDisponibles = datos.nivelesDesbloqueados;
        }
        else
        {
            ControladorJuego.nivelesDisponibles = 0;
        }
    }
}

[System.Serializable]
class GuardarDatos
{
    public int nivelesDesbloqueados;

    public GuardarDatos(int nivelesDes)
    {
        nivelesDesbloqueados = nivelesDes;
    }
}