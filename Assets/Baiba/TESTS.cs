using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TESTS : MonoBehaviour
{
    public MeshRenderer mesh;

    public void CambiarColor()
    {
        mesh.material.color = Random.ColorHSV();
    }
}
