using UnityEngine;
using System.Collections;

public class Character2DController : MonoBehaviour {
	Vector3 velocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		Ray ray = new Ray(transform.position, Vector3.up);
		float distance = velocity.y;
		RaycastHit hitInformation;

		int mask = LayerMask.NameToLayer("normalCollision");

		bool somethingAboveMe = Physics.Raycast(ray, out hitInformation, distance, mask);

		if(somethingAboveMe){
			Debug.Log("Above Hit" + hitInformation.distance);
		}
	}
}
