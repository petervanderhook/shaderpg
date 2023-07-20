using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnMouseOver() {
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Picked up item.");
            Destroy(gameObject);
        }
    }
}
