using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TechTree
{
    [CreateAssetMenu(menuName = "TechTree/Node", fileName = "Node")]
    public class TechTreeNode : ScriptableObject
    {
        public static void Test(string str) => Debug.Log(str);

        [SerializeField] private Vector3 position;
        [SerializeField] private UnityEvent events;

        public Vector3 Position => position;
        
    }
}
