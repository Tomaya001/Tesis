using com.baiba.core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntregaScript : MonoBehaviour
{
    public List<IngredientList> pedidosList;
    public Text txtPedido;

    IngredientList orden;

    private void Start()
    {
        txtPedido.text = null;
        orden = pedidosList[Random.Range(0, pedidosList.Count)];
        for (int i = 0; i < orden.ingredientList.Count; i++)
        {
            for (int j = 0; j < orden.ingredientList.Count; j++)
            {
                txtPedido.text += orden.ingredientList[j].id + '\n';
            }
            break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bandeja"))
        {
            CompararOrden(other.gameObject.GetComponent<IngredientList>());
            other.gameObject.GetComponent<PickUpBandeja>().Limpiar();
        }
    }

    public void CompararOrden(IngredientList list)
    {
        for (int i = 0; i < orden.ingredientList.Count; i++)
        {
            for (int j = 0; j < list.ingredientList.Count; j++)
            {
                if (orden.ingredientList[i].Equals(list.ingredientList[j]))
                    j++;
                else
                    Debug.Log("Oreden Equivocada, Perdiste Loseeer");
            }
            i++;
        }
    }
}
