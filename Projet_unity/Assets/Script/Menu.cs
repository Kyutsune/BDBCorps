using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector3 mousePosition;

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        Debug.Log("fonctionne");
        mousePosition= Input.mousePosition - GetMousePos();
        
    }

    private void OnMouseDrag()
    {
        transform.position=Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }


}
 