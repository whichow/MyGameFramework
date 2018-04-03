using UnityEngine;  
using System.Collections;  
  
public class GridMap : MonoBehaviour {  
  
    public static GridMap Instance=null;  
  
    public int MapSizeX;  
    public int MapSizeZ;  
  
    [HideInInspector]  
    public GameObject[] mNodes;  
    [HideInInspector]  
    public GameObject[] mPaths;  
      
    void Awake()  
    {  
        Instance=this;   
    }  
  
    void DrawGrid()  
    {  
        Gizmos.color=Color.blue;  
        for(int i=0;i<=MapSizeX;i++)  
        {  
            Gizmos.DrawLine(new Vector3(i,0,0),new Vector3(i,0,MapSizeZ));  
        }  
        for(int j=0;j<=MapSizeZ;j++)  
        {  
            Gizmos.DrawLine(new Vector3(0,0,j),new Vector3(MapSizeX,0,j));  
        }  
    }  
  
    void DrawColor()  
    {  
        // if(mNodes==null) return;  
        // foreach(GameObject go in mNodes)  
        // {  
        //     Vector3 mPos=go.transform.position;  
        //     if(go.GetComponent<GridNode>()!=null){  
        //         if(go.GetComponent<GridNode>().GridNodeType==GridNode.NodeType.CanPlace){  
        //             Gizmos.color=Color.green;  
        //         }else if(go.GetComponent<GridNode>().GridNodeType==GridNode.NodeType.CantPlace){  
        //             Gizmos.color=Color.red;  
        //         }  
        //         Gizmos.DrawCube(mPos,new Vector3(1,1,1));  
        //     }  
        // }  
    }  
  
    void DrawPath()  
    {  
        // Gizmos.color=Color.white;  
        // if(mPaths==null) return;  
        // foreach(GameObject go in mPaths)  
        // {  
        //     if(go.GetComponent<PathNode>()!=null){  
        //         PathNode node=go.GetComponent<PathNode>();  
        //         if(node.ThatNode!=null){  
        //            Gizmos.DrawLine(node.transform.position,node.ThatNode.transform.position);  
        //         }  
        //     }  
        // }  
    }  
      
    void OnDrawGizmos()  
    {  
        DrawGrid();  
        DrawColor();  
        DrawPath();  
    }  
  
  
}  