using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TechTree;

public class TechTreeManager : MonoBehaviour
{
    [SerializeField] private TechTreeTable table;
    [SerializeField] private GameObject nodePrefeb;
    [SerializeField] private GameObject linePrefeb;
    [SerializeField] private RectTransform canvas;

    private void Awake() 
    {
        for(int i = 0; i < table.Nodes.Count; i++)
        {
            for(int k = 0; k < table.Nodes[i].Nexts.Count; k++)
            {
                var line = Instantiate(linePrefeb, canvas).GetComponent<LineImage>();
                line.pointA = table.Nodes[i].Position;
                line.pointB = table.Nodes[i].Nexts[k].Position;
            }
        }
        for(int i = 0; i < table.Nodes.Count; i++)
        {
            var node = Instantiate(nodePrefeb, canvas);
            node.transform.localPosition = table.Nodes[i].Position;
            node.GetComponent<NodeBehaviour>().SetNode(table.Nodes[i]);
        }
    }
}
