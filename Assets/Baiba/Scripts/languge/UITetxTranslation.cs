using com.baiba.lang;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITetxTranslation : MonoBehaviour
{
    public string key;
    private Text UIText;

    void Awake()
    {
        GetUIText();
    }

    private void GetUIText()
    {
        UIText = GetComponent<Text>();
    }

    public void SetText()
    {
        if (UIText == null)
        {
            GetUIText();
        }

        UIText.text = Language.instance.GetString(key);
    }
}
