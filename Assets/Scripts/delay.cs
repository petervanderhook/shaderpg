using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    public GameObject player, camdelay;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerArmature");
        camdelay = GameObject.Find("PlayerFollowObject");
    }

    // Update is called once per frame
    void Update()
    {
        float dog = Vector3.Distance(camdelay.transform.position, player.transform.position);
        //Debug.Log(dog);

        if (dog > 3f) {
            camdelay.transform.position = Vector3.MoveTowards(camdelay.transform.position, player.transform.position, 10f * Time.deltaTime);
        }
        else if (dog > 1.5f) {
            camdelay.transform.position = Vector3.MoveTowards(camdelay.transform.position, player.transform.position, 6f * Time.deltaTime);
        }
    }
}
