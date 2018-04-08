using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    private PathNode[] nodes;

    void Start()
    {
        nodes = GetComponentsInChildren<PathNode>();
        for (int i = 0; i < nodes.Length - 1; i++)
        {
            nodes[i].next = nodes[i + 1];
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        for (int i = 1; i < transform.childCount; i++)
        {
            Gizmos.DrawLine(transform.GetChild(i - 1).position, transform.GetChild(i).position);
        }
    }

    public PathNode[] GetPathNodes()
    {
        return nodes;
    }

    public PathNode GetPathNode(int index)
    {
        if (index < nodes.Length)
        {
            return nodes[index];
        }
        return null;
    }
}
