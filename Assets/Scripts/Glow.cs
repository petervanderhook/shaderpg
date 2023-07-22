using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    public MeshRenderer mesh_renderer;
    public GameObject health_pot;
    public Light PotionLight;
    public Material hover_mat;
    public Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mesh_renderer = GetComponent<MeshRenderer>();
        hover_mat = Resources.Load("Materials/Potion", typeof(Material)) as Material;
        mat = mesh_renderer.material;
        mesh_renderer.material = mat;
        PotionLight.enabled = false;
    }
    void OnMouseEnter() {
        PotionLight.enabled = true;
        mesh_renderer.material = hover_mat;
        Debug.Log("OnMouseEnter");
    }
    void OnMouseExit() {
        PotionLight.enabled = false;
        mesh_renderer.material = mat;
        Debug.Log("OnMouseExit");
    }


}