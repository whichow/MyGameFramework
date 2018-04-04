using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenPath : MonoBehaviour
{
    // private Path path;
    public PathNode node;

    void Start()
    {
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
