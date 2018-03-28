using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// 协程管理器
/// </summary>
public class CoroutineManager : MonoSingleton<CoroutineManager>
{
    /// <summary>
    /// 启动一个协程
    /// </summary>
    /// <param name="coroutine"></param>
    public new Coroutine StartCoroutine(IEnumerator routine)
    {
        var coroutine = base.StartCoroutine(routine);
        return coroutine;
    }
    /// <summary>
    /// 终止一个协程
    /// </summary>
    /// <param name="coroutine"></param>
    public new void StopCoroutine(Coroutine routine)
    {
        base.StopCoroutine(routine);
    }
}