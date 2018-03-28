using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tabs : MonoBehaviour
{
    public Transform tabsRoot;

    private Transform[] _childTabs;

    void Awake()
    {
        _childTabs = new Transform[tabsRoot.childCount];
        for (int i = 0; i < _childTabs.Length; i++)
        {
            _childTabs[i] = tabsRoot.GetChild(i);
			if(i != 0)
			{
				_childTabs[i].gameObject.SetActive(false);
			}
        }
    }

    public void HideAll()
    {
        for (int i = 0; i < _childTabs.Length; i++)
        {
            _childTabs[i].gameObject.SetActive(false);
        }
    }
}
