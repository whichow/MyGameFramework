using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pages : MonoBehaviour
{
    public RectTransform pageRoot;
    public Vector2 childSize;
    public float space;
    public float speed;

    private Transform[] pages;
    private bool isMoving;
    private Vector3 targetPos;


    public int CurrentIndex
    {
        get;
        private set;
    }

    void Awake()
    {
        pageRoot.sizeDelta = new Vector2(childSize.x + space * (pageRoot.childCount - 1), childSize.y);
        pages = new Transform[pageRoot.childCount];
        for (int i = 0; i < pageRoot.childCount; i++)
        {
            var child = pageRoot.GetChild(i);
            child.localPosition += new Vector3(space * i, 0f, 0f);
            pages[i] = child;
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Previous();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Next();
        }

        float step = speed * Time.deltaTime * 1000;
        if (isMoving)
        {
            pageRoot.localPosition = Vector3.MoveTowards(pageRoot.localPosition, targetPos, step);
            if (pageRoot.localPosition == targetPos)
            {
                isMoving = false;
            }
        }
    }

    public void Next()
    {
        if (isMoving || CurrentIndex == pages.Length - 1)
        {
            return;
        }
        targetPos = pageRoot.localPosition - new Vector3(space, 0f, 0f);
        isMoving = true;
        CurrentIndex++;
    }

    public void Previous()
    {
        if (isMoving || CurrentIndex == 0)
        {
            return;
        }
        targetPos = pageRoot.localPosition + new Vector3(space, 0f, 0f);
        isMoving = true;
        CurrentIndex--;
    }
}
