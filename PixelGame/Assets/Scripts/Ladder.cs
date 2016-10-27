using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Started");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.name == "Player")
		{
			collider.gameObject.GetComponent<PlayerMovement>().onLadder = true;
		}
	}
	void OnTriggerExit2D(Collider2D collider)
	{
		if(collider.gameObject.name == "Player")
		{
			collider.gameObject.GetComponent<PlayerMovement>().onLadder = false;
		}
	}
}
