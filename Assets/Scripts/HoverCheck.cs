using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverCheck : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Checking for Hovers...");
    }
    private void OnMouseEnter()
    {
        Debug.Log("On Mouse Enter...");
    }
    private void OnMouseExit()
    {
        Debug.Log("On Mouse Exit...");
    }
}