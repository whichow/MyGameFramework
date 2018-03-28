using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Object = UnityEngine.Object;

public class ResourceManager
{
    public static T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public static Object Load(string path)
    {
        return Resources.Load(path);
    }

    public static T LoadInstantiate<T>(string path) where T : Object
    {
        return Object.Instantiate(Load<T>(path));
    }

    public static Object LoadInstantiate(string path)
    {
        return Object.Instantiate(Resources.Load(path));
    }
}
