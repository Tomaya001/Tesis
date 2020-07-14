using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntregaScript : MonoBehaviour
{
    public List<ingListScript> pedidosList;
    public Text txtPedido;

    ingListScript orden;

    private void Start()
    {
        txtPedido.text = null;
        orden = pedidosList[Random.Range(0, pedidosList.Count)];
        for (int i = 0; i < orden.ingList.Count; i++)
        {
            txtPedido.text += orden.ingList[i];
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bandeja"))
        {
            Compararorden(other.gameObject.GetComponent<ingListScript>());
            other.gameObject.GetComponent<PickUpBandeja>().Limpiar();
        }
    }

    public void Compararorden(ingListScript list)
    {
        for (int i = 0; i < orden.ingList.Count; i++)
        {
            for (int j = 0; j < list.ingList.Count; j++)
            {
                if (orden.ingList[i].Equals(list.ingList[j]))
                    j++;
                else
                    Debug.Log("Oreden Equivocada, Perdiste Loseeer");
            }
            i++;
        }
    }
}
