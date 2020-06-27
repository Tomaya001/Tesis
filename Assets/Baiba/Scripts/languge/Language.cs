using com.baiba.core;
using com.baiba.storage;
using com.baiba.config;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.baiba.lang
{
    public class Language
    {
        //Instanciamiento Estatico
        private static Language _instance;
        public static Language instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Language();
                }
                return _instance;
            }
        }
        //FIN Instanciamiento Estatico

        private Dictionary<string, string> language;

        public void Init()
        {
            Init(GetCurrentLanguage());
        }

        public void Init(string lang)
        {
            TextAsset ta = AssetLoader.GetAsset<TextAsset>(Const.RESOURCES.LANG_FOLDER + lang);
            LanguageList langList = JsonUtility.FromJson<LanguageList>(ta.text);

            language = new Dictionary<string, string>();

            foreach (LanguageRef langRef in langList.lang)
            {
                language.Add(langRef.key, langRef.value);
            }

            OnChangeLanguage(lang);
            Storage.SaveString(Const.STORAGE.KEY_LANG, lang);
            
        }

        public string GetString(string key)
        {
            if (language.ContainsKey(key))
            {
                return language[key];
            }

            return key;
        }

        public void OnChangeLanguage()
        {
            OnChangeLanguage(GetCurrentLanguage());
        }

        public void OnChangeLanguage(string lang)
        {
            UITetxTranslation[] tt = GameObject.FindObjectsOfType<UITetxTranslation>();
            foreach (UITetxTranslation t in tt)
            {
                t.SetText();
            }
        }

        public string GetCurrentLanguage()
        {
            return Storage.GetString(Const.STORAGE.KEY_LANG, Config.instance.lang.defaultValue);
        }
    }
}
