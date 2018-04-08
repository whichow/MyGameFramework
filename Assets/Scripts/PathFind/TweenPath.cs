using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenPath : MonoBehaviour
{
    // private Path path;
    private PathNode node;

    void Start()
    {
        var path = GameObject.Find("Path").GetComponent<Path>();
        node = path.GetPathNode(0);
        transform.position = node.transform.position;
    }

    void Update()
    {
        if (node == null)
        {
            return;
        }

        if (transform.position != node.transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, node.transform.position, Time.deltaTime * 10f);
        }
        else
        {
            node = node.next;
            if (node != null)
            {
                transform.LookAt(node.transform);
            }
        }
    }
}
