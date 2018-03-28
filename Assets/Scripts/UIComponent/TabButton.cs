using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TabButton : Selectable, IPointerClickHandler
{
    public GameObject tab;
    private Tabs _tabs;

    protected override void Awake()
    {
        _tabs = gameObject.GetComponentInParent<Tabs>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _tabs.HideAll();
        if (tab != null)
            tab.SetActive(true);
    }
}
