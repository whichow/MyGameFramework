using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGrid : MonoBehaviour
{
	public Material mat;
    public Terrain terrain;
    private float[,] map;

    // Use this for initialization
    void Start()
    {
        var data = terrain.terrainData;
        int x = (int)data.size.x + 1;
        int z = (int)data.size.z + 1;
        Debug.Log(data.size);
        map = new float[x, z];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < z; j++)
            {
                // var h = data.GetHeight(i, j);
                var h = terrain.SampleHeight(new Vector3(i, 0, j));
                map[i, j] = h;
            }
        }
    }

    // Update is called once per frame
    void OnPostRender()
    {
        // for (int i = 0; i < map.GetLength(0); i++)
        // {
        //     for (int j = 0; j < map.GetLength(1); j++)
        //     {
        // 		if(i > 0)
        // 		{
        // 			Debug.DrawLine(new Vector3(i - 1, map[i - 1, j], j), new Vector3(i, map[i, j], j));
        // 		}
        // 		if(j > 0)
        // 		{
        // 			Debug.DrawLine(new Vector3(i, map[i, j - 1], j - 1), new Vector3(i, map[i, j], j));
        // 		}
        //     }
        // }
		// GL.PushMatrix();
		mat.SetPass(0);
		GL.Begin(GL.LINES);
		GL.Color(Color.red);
        for (int i = 1; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j += 4)
            {
				GL.Vertex(new Vector3(i - 1, map[i - 1, j], j) + terrain.transform.position);
				GL.Vertex(new Vector3(i, map[i, j], j) + terrain.transform.position);
                // Debug.DrawLine(new Vector3(i - 1, map[i - 1, j], j) + transform.position, new Vector3(i, map[i, j], j) + transform.position);
            }
        }

        for (int j = 1; j < map.GetLength(1); j++)
        {
            for (int i = 0; i < map.GetLength(1); i += 4)
            {
				GL.Vertex(new Vector3(i, map[i, j - 1], j - 1) + terrain.transform.position);
				GL.Vertex(new Vector3(i, map[i, j], j) + terrain.transform.position);
                // Debug.DrawLine(new Vector3(i, map[i, j - 1], j - 1) + transform.position, new Vector3(i, map[i, j], j) + transform.position);
            }
        }
		GL.End();
		// GL.PopMatrix();
    }
}
