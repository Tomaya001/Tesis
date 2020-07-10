using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesadaType : MonoBehaviour
{
    [Header("Agregar Referencias")]
    public GameObject estufa;
    public GameObject tabla;
    public GameObject ingrediente;
    public GameObject lavavajilla;

    [Header("Selecionar Tipo")]
    public Tipo SelecionarTipo;


    MeshRenderer mesh;
    Transform t;


    public enum Tipo 
    { 
        Ninguno,
        Estufa,
        Tabla,
        Ingrediente,
        LavaVajilla,
    }

    void Awake()
    {
        mesh = GetComponent<MeshRenderer>();
        t = transform;
        AsignarTipo();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void AsignarTipo()
    {
        switch(SelecionarTipo)
        {
            case Tipo.Estufa:
                Transformar(estufa);
                break;
            case Tipo.Ingrediente:
                Transformar(ingrediente);
                break;
            case Tipo.LavaVajilla:
                Transformar(lavavajilla);
                break;
            case Tipo.Tabla:
                Transformar(tabla);
                break;
        }
    }
    
    void Transformar(GameObject obj)
    {
        mesh.enabled = false;
        Instantiate(obj, t);
    }
}
