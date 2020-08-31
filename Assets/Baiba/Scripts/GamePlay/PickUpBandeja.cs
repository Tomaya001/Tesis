using com.baiba.player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBandeja : MonoBehaviour
{
    [Header("Conteiner")]
    public ContType type;

    public GameObject ObjectToPickUp;
    public List<GameObject> PickedObjectList;
    public Transform[] points;
    public int poss;


    public IngredientList list;

    public enum ContType
    {
        Player,
        Bandeja
    }

    private void Start()
    {
        if (type == ContType.Bandeja)
        {
            list = new IngredientList();
        }

        poss = 0;
    }

    void Agarrar()
    {
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickableObjects>().isPickable)
        {
            PickedObjectList.Add(ObjectToPickUp);
            PickedObjectList[poss].GetComponent<PickableObjects>().isPickable = false;
            PickedObjectList[poss].transform.SetParent(points[poss]);
            PickedObjectList[poss].transform.position = points[poss].position;
            PickedObjectList[poss].GetComponent<Rigidbody>().useGravity = false;
            PickedObjectList[poss].GetComponent<Rigidbody>().isKinematic = true;
            list.ingredientList.Add(PickedObjectList[poss].GetComponent<IngredientClass>());
            poss++;
        }
    }

    void Soltar()
    {
        PickedObjectList[poss].GetComponent<PickableObjects>().isPickable = true;
        PickedObjectList[poss].transform.SetParent(null);
        //PickedObject.transform.position = hand.position;
        PickedObjectList[poss].GetComponent<Rigidbody>().useGravity = true;
        PickedObjectList[poss].GetComponent<Rigidbody>().isKinematic = false;
        PickedObjectList[poss] = null;
    }

    public void Limpiar()
    {
        for (int i = 0; i < PickedObjectList.Count; i++)
        {
            PickedObjectList[i].GetComponent<PickableObjects>().isPickable = true;
            PickedObjectList[i].transform.SetParent(null);
            PickedObjectList[i].SetActive(false);
        }
        this.gameObject.GetComponent<PickableObjects>().isPickable = true;
        this.gameObject.transform.SetParent(null);
        this.gameObject.transform.position = new Vector3(0, 1, 0);
        list.ingredientList.Clear();
    }

    public void AgarraroSoltar()
    {
        if (ObjectToPickUp.CompareTag("Ingrediente"))
            {
                Agarrar();
            }
            

        /*if (!this.gameObject.GetComponent<PickableObjects>().isPickable)
        {
            Agarrar();
        }
        else
        {
            Debug.Log("La Bandeja no esta disponible");
        }*/
    }
}


