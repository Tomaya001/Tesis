using com.baiba.player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBandeja : MonoBehaviour
{
    public GameObject ObjectToPickUp;
    public List<GameObject> PickedObjectList;
    public Transform[] points;
    public int poss;
    ingListScript list;

    private void Start()
    {
        list = gameObject.GetComponent<ingListScript>();
        poss = 0;
    }

    void Agarrar()
    {
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickableObjectforBandeja>().isPickable)
        {
            PickedObjectList.Add(ObjectToPickUp);
            PickedObjectList[poss].GetComponent<PickableObjectforBandeja>().isPickable = false;
            PickedObjectList[poss].transform.SetParent(points[poss]);
            PickedObjectList[poss].transform.position = points[poss].position;
            PickedObjectList[poss].GetComponent<Rigidbody>().useGravity = false;
            PickedObjectList[poss].GetComponent<Rigidbody>().isKinematic = true;
            list.ingList.Add(PickedObjectList[poss].GetComponent<IngredieteScrip>().id);
            poss++;
        }
    }

    void Soltar()
    {
        PickedObjectList[poss].GetComponent<PickableObjectforBandeja>().isPickable = true;
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
            PickedObjectList[i].GetComponent<PickableObjectforBandeja>().isPickable = true;
            PickedObjectList[i].transform.SetParent(null);
            PickedObjectList[i].SetActive(false);
        }
        this.gameObject.GetComponent<PickableObjects>().isPickable = true;
        this.gameObject.transform.SetParent(null);
        this.gameObject.transform.position = new Vector3(0, 1, 0);
        list.ingList.Clear();
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
