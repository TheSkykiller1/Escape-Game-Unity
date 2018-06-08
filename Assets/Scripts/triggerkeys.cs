using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRTK.Examples
{
	public class triggerkeys : MonoBehaviour {
	public Transform coffretournevis;
	private Rigidbody Door;
	
	private bool key1_enter = false;
	private bool key2_enter = false;
	
	void OnTriggerEnter(Collider obj){
		if (obj.transform.name == "keys_locks"){
			key1_enter=true;
		}
		else if(obj.transform.name == "keys_locks2")
		{
			key2_enter=true;
		}
		else if((key2_enter==true) && (key1_enter==true))
		{
			OpencoffreTel();
		}
		
	}

	void OpencoffreTel(){
		Door= coffretournevis.GetComponent<Rigidbody>();
		Door.freezeRotation = false;
	}
	}
}
