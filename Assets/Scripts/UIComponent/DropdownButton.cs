using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropdownButton : Selectable, IPointerClickHandler
{
    public bool isShow = false;

    private Transform[] _childItems;

    protected override void Awake()
    {
        base.Awake();
        _childItems = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            var item = transform.GetChild(i);
            _childItems[i] = item;
        }
		if(isShow)
		{
			ShowChildren();
		}
		else
		{
			HideChildren();
		}
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isShow)
        {
			HideChildren();
            isShow = false;
        }
        else
        {
			ShowChildren();
            isShow = true;
        }
    }

    private void ShowChildren()
    {
        for (int i = 0; i < _childItems.Length; i++)
        {
            _childItems[i].gameObject.SetActive(true);
        }
    }

    private void HideChildren()
    {
        for (int i = 0; i < _childItems.Length; i++)
        {
            _childItems[i].gameObject.SetActive(false);
        }
    }
}
