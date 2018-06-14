using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggered : MonoBehaviour {
    public Transform Steel_Window;
	public Transform TriggerBlock;
    public Transform Grabobject;
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
        Grabobject.position = new Vector3(
            Grabobject.position.x,
            Grabobject.position.y,
            Grabobject.position.z - movement
            );
		TriggerBlock.position = new Vector3(
            TriggerBlock.position.x,
            TriggerBlock.position.y,
            TriggerBlock.position.z + movement
        );
    }
}
