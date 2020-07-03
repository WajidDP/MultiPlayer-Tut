using System.Linq;
using UnityEngine;

public abstract class SingletenScriptableObject<T> : ScriptableObject where T : ScriptableObject
{

    private static T _instance = null;

    public static T Instance 
    {
        get
        {
            if (_instance == null)
            {
                T[] result = Resources.FindObjectsOfTypeAll<T>();
                if (result.Length == 0) 
                {
                    Debug.LogError("SingletonScriptableObject -> Intance -> result length is 0");
                    return null;
                }
                if (result.Length > 1) 
                {
                    Debug.LogError("SingletonScriptableObject -> Intance -> result length is greater than one");
                    return null;
                }
                _instance = result[0];
            }
            
              
            return _instance;
        }
    }
}
