using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	public Troop prefab;
	public Transform target;

	// Use this for initialization
	void Start () {
		Troop troop = Instantiate(prefab, gameObject.transform.position, Quaternion.identity) as Troop;
		troop.march (target, gameObject.transform);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
