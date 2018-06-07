using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggered : MonoBehaviour {
    public Transform Steel_Window;
    void OnTriggerEnter(Collider obj)
    {
        if (obj.transform.name == "tournevis")
        {
            Opengrille();
        }
    }
    void Opengrille()
    {
        float movement = 3.0f;
        Steel_Window.position = new Vector3(
            Steel_Window.position.x,
            Steel_Window.position.y,
            Steel_Window.position.z + movement
        );
    }
}
