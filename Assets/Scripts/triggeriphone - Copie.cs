using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK.Examples
{
	public class triggeriphone111 : MonoBehaviour {
	private VRTK_Door Door;
	public bool openingcoffreTel = false;
	public Transform coffreiphone;
	
	void Start () {
		Door= coffreiphone.GetComponent<VRTK_Door>();
		Door.maxAngle = 0.0f;
	}
	
	void Update(){
		if (openingcoffreTel) OpencoffreTel();
	}
	void OnTriggerEnter(Collider obj){
		if (obj.transform.name == "iphone"){
			openingcoffreTel = true;
		}
	}

	void OpencoffreTel(){
		Door= coffreiphone.GetComponent<VRTK_Door>();
		Door.maxAngle = 90.0f;
	}
	}
}
