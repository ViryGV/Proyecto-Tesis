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
        GuardarDatos datos = new GuardarDatos(ControladorJuego.nivelesDisponibles, ControladorJuego.nivelesDisponiblesAtencion);
        //Algo datosAtencion = new Algo(ControladorJuego.nivelesDisponiblesAtencion);
        bf.Serialize(file, datos);
        //bf.Serialize(file, datosAtencion);
        file.Close();
    }

    public void Cargar()
    {
        if (File.Exists(_rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(_rutaArchivo, FileMode.Open);
            GuardarDatos datos = (GuardarDatos)bf.Deserialize(file);
            //Algo datosAtencion = (Algo)bf.Deserialize(file);
            ControladorJuego.nivelesDisponibles = datos.nivelesDesbloqueados;
            ControladorJuego.nivelesDisponiblesAtencion = datos.nivelesDesbloqueadosAtencion;
        }
        else
        {
            ControladorJuego.nivelesDisponibles = 0;
            ControladorJuego.nivelesDisponiblesAtencion = 0;
        }
    }
}

[System.Serializable]
class GuardarDatos
{
    public int nivelesDesbloqueados;
    public int nivelesDesbloqueadosAtencion;

    public GuardarDatos(int nivelesDes, int nivelesADes)
    {
        nivelesDesbloqueados = nivelesDes;
        nivelesDesbloqueadosAtencion = nivelesADes;
}

    /*public Atencion(int nivelesAtencionDes)
    {
        nivelesDesbloqueados = nivelesDes;
    }*/
}

/*[System.Serializable]
class Algo
{
    public int nivelesDesbloqueadosAtencion;

    public Algo(int nivelesDes)
    {
        nivelesDesbloqueadosAtencion = nivelesDes;
    }
}*/