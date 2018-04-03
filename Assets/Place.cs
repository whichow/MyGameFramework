using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
	public float height = 2.5f;
	
	public Vector3 GetPlace()
	{
		return transform.position + new Vector3(0f, height, 0f);
	}
}
