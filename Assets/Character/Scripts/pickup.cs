using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse_pos = Input.mousePosition;
        //Debug.Log(mouse_pos);
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(mouse_pos);
        Debug.DrawRay(cam.transform.position, Input.mousePosition * -10000, Color.green);
       //Debug.DrawRay(cam.transform.position, ray.direction * 2000, Color.green);
        if (Input.GetMouseButtonDown(0)) {
            print(mouse_pos);
            if (Physics.Raycast(ray, out hit, 50000.0f)) {
                Debug.Log(hit.collider.tag);
            }
        }
    }
}