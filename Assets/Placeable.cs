using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placeable : MonoBehaviour
{
	public bool isPlacing;
	private bool canPlace;
	private int layerMask;

	void Awake()
	{
		layerMask = LayerMask.GetMask("Terrain", "Place");
	}

    // Update is called once per frame
    void Update()
    {
		canPlace = false;
		if(!isPlacing)
		{
			return;
		}
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if(Physics.Raycast(ray, out hit, Mathf.Infinity, layerMask))
		{
			var place = hit.collider.GetComponent<Place>();
			if(place != null)
			{
				transform.position = place.GetPlace();
				canPlace = true;
			}
			else
			{
				transform.position = hit.point;
			}
		}
    }

	public bool CanPlace()
	{
		return canPlace;
	}
}
