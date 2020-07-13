using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandeja : MonoBehaviour
{
    public List<GameObject> bandeja;

    public void AddIngredient(GameObject ing)
    {
        bandeja.Add(ing);
    }

    public void Vaciar()
    {
        bandeja.Clear();
    }

    public void Dejar(int poss)
    {
        bandeja.RemoveAt(poss);
    }

    public List<GameObject> GetBandeja()
    {
        return bandeja;
    }

}
