using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class LineImage : MonoBehaviour 
{
    private RectTransform imageRectTransform;
    public float lineWidth = 1.0f;
    public Vector3 pointA;
    public Vector3 pointB;

    void Start () 
    {
        imageRectTransform = GetComponent<RectTransform>();
    }
     
    void Update () 
    {
        Vector3 differenceVector = pointB - pointA;
 
        imageRectTransform.sizeDelta = new Vector2(differenceVector.magnitude, lineWidth);
        imageRectTransform.pivot = new Vector2(0, 0.5f);
        imageRectTransform.localPosition = pointA;
        float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
        imageRectTransform.rotation = Quaternion.Euler(0, 0, angle);
    }
}