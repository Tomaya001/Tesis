using com.baiba.player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentBasedTime : MonoBehaviour
{

    public float timeA;
    public float timeB;

    public GameObject[] estados;

    bool trash;
    bool ready;

    MeshCollider col;

    private void Awake()
    {
        trash = gameObject.GetComponent<PickableObjects>().isTrash;
        ready = gameObject.GetComponent<PickableObjects>().isPickable;
        col = gameObject.GetComponent<MeshCollider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ready = false;
        estados[0].SetActive(true);
        col.sharedMesh = estados[0].GetComponent<MeshFilter>().mesh;
        StartCoroutine(CoolDonw());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CoolDonw()
    {
        yield return new WaitForSeconds(timeA);
        ready = true;
        estados[0].SetActive(false);
        estados[1].SetActive(true);
        col.sharedMesh.Clear();
        col.sharedMesh = estados[0].GetComponent<MeshFilter>().mesh;
        yield return new WaitForSeconds(timeB);
        if(ready)
        {
            trash = true;
            estados[1].SetActive(false);
            estados[2].SetActive(true);
            col.sharedMesh.Clear();
            col.sharedMesh = estados[0].GetComponent<MeshFilter>().mesh;
        }        
    }
}
