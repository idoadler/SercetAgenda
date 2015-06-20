using UnityEngine;
using System.Collections;

public class Backline : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Application.LoadLevel(0);
	}
}
