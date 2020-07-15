using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bandejaBehavior : MonoBehaviour
{
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;
    public GameObject pos5;
    public GameObject pos6;
    public int currentPos;
    void Start()
    {
        currentPos = 1;
    }

   public void AddtoOrder(GameObject _inst)
    {
        switch (currentPos)
        {
            case 1:
                Instantiate(_inst, pos1.transform);
                currentPos++;
                break;
            case 2:
                Instantiate(_inst, pos2.transform);
                currentPos++;
                break;
            case 3:
                Instantiate(_inst, pos3.transform);
                currentPos++;
                break;
            case 4:
                Instantiate(_inst, pos4.transform);
                currentPos++;
                break;
            case 5:
                Instantiate(_inst, pos5.transform);
                currentPos++;
                break;
            case 6:
                Instantiate(_inst, pos6.transform);
                currentPos++;
                break;
            case 7:
                Debug.Log("No tenés más espacio wachin");
                break;
        }
   }
}
