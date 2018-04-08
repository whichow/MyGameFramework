using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystem
{
    private static readonly float DOUBLE_CLICK_TIME_INTERVAL = 0.5f;
    private GameObject clickObject;
    private float clickTime;
    private int layerMask;

    public void Init()
    {
        layerMask = LayerMask.GetMask("Tower", "Enemy");
    }

    public void Release()
    {
        clickObject = null;
    }

    public void Update()
    {
		ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
            {
                if (Time.time - clickTime < DOUBLE_CLICK_TIME_INTERVAL && clickObject == hit.collider.gameObject)
                {
                    clickTime = 0f;
                    var clickable = clickObject.GetComponent<Clickable>();
                    if (clickable != null)
                    {
                        clickable.DoubleClick();
                    }
                }
                else
                {
                    clickObject = hit.collider.gameObject;
                    clickTime = Time.time;
                    var clickable = clickObject.GetComponent<Clickable>();
                    if (clickable != null)
                    {
                        clickable.Click();
                    }
                }
            }
            else
            {
                clickObject = null;
            }
        }
    }
}
