using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK.Examples
{
	public class triggeriphone : MonoBehaviour {
	public Transform coffreiphone;
	private Rigidbody Door;
	void OnTriggerEnter(Collider obj){
		if (obj.transform.name == "iphone"){
			OpencoffreTel();
		}
	}

	void OpencoffreTel(){
		Door= coffreiphone.GetComponent<Rigidbody>();
		Door.freezeRotation = false;
	}
	}
}
