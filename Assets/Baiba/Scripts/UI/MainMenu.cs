﻿using com.baiba.lang;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private void OnEnable()
    {
        Language.instance.Init();
    }
}
