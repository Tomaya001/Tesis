using com.baiba.core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.baiba.config
{
    public class Config
    {
        //Instanciamiento Estatico
        private static Config _instance;
        public static Config instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Config();
                    _instance.Init();
                }
                return _instance;
            }
        }
        //FIN Instanciamiento Estatico

        private void Init()
        {
            TextAsset ta = AssetLoader.GetAsset<TextAsset>(Const.RESOURCES.CONFIG_FILE);
            variables = JsonUtility.FromJson<Variables>(ta.text);
        }

        private Variables variables;
        public Lang lang { get { return variables.lang; } }

        [Serializable]
        public class Variables
        {
            public Lang lang;
        }

        [Serializable]
        public class Lang
        {
            public string defaultValue;
            public List<string> list;
        }
    }
}

