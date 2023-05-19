using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TechTree;

public class NodeBehaviour : MonoBehaviour
{
    [SerializeField] private TechTreeTable table;
    [SerializeField] private TechTreeNode node;

    private Button btn;

    public void SetNode(TechTreeNode node)
    {
        this.node = node;
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => node.Active = true);
    }
}
