using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour {

	void OnEnable()
	{
		TouchEventManager.onTouch += Teleport;
	}
	
	
	void OnDisable()
	{
		TouchEventManager.onTouch -= Teleport;
	}
	
	
	void Teleport()
	{
		Vector3 pos = transform.position;
		pos.x += Random.Range(-30.0f, 30.0f);
		pos.z += Random.Range (-30.0f, 30.0f);
		transform.position = pos;
	}

}
