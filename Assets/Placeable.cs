using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : MonoBehaviour
{
	public bool isPlacing;
	private RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
		if(!isPlacing)
		{
			return;
		}
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit, Mathf.Infinity))
		{
			var place = hit.collider.GetComponent<Place>();
			if(place != null)
			{
				transform.position = place.GetPlace();
			}
			else
			{
				transform.position = hit.point;
			}
		}
    }
}
