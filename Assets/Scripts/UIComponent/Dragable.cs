using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Dragable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public UnityEvent onDragBegin = new UnityEvent();
    public UnityEvent onDrag = new UnityEvent();
    public UnityEvent onDragEnd = new UnityEvent();

    public void OnBeginDrag(PointerEventData eventData)
    {
        onDragBegin.Invoke();
    }

    public void OnDrag(PointerEventData eventData)
    {
        onDrag.Invoke();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        onDragEnd.Invoke();
    }
}
