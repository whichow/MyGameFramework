using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    public Action onClick;
    public Action onDoubleClick;

    public virtual void Click()
    {
        if (onClick != null)
        {
            onClick();
        }
    }

    public virtual void DoubleClick()
    {
        if (onDoubleClick != null)
        {
            onDoubleClick();
        }
    }
}
