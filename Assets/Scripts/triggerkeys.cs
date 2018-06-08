using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK.Examples
{
	public class triggerkeys : MonoBehaviour {
	public Transform coffretournevis;
	private Rigidbody Door;
	void OnTriggerEnter(Collider obj){
		if (obj.transform.name == "keys_locks"){
			OpencoffreTel();
		}
	}

	void OpencoffreTel(){
		Door= coffretournevis.GetComponent<Rigidbody>();
		Door.freezeRotation = false;
	}
	}
}
