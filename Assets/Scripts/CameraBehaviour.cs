using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {
	
	public GameObject pivot;
	public GameObject follow;
	public float speed = 1f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float distance = speed;
		if (follow.transform.position.z > pivot.transform.position.z) 
		{
			distance += follow.transform.position.z - pivot.transform.position.z;
		}
		gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,distance+gameObject.transform.position.z);
	}
}
