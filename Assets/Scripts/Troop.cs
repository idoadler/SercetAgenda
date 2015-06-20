using UnityEngine;
using System.Collections;

public class Troop : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public Transform target;
	public Transform origin;
	public float rotateSpeed;
	public float movementSpeed;
	public float actionTime;
	private bool goToTarget = true;
	void Update() {
		if (target != null) {
			if (goToTarget)
			{
				Vector3 targetDir = target.position - transform.position;
				float rotate = rotateSpeed * Time.deltaTime;
				Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, rotate, 0.0F);
				Debug.DrawRay (transform.position, newDir, Color.red);
				transform.rotation = Quaternion.LookRotation (newDir);
				float move = movementSpeed * Time.deltaTime;
				transform.position = Vector3.MoveTowards(transform.position, target.position, move);
				if (Vector3.Distance (transform.position, target.position) < 0.1f)
					goToTarget = false;
			}
			else if (actionTime > 0)
			{
				Vector3 targetDir = origin.position - transform.position;
				float rotate = rotateSpeed * Time.deltaTime;
				Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, rotate, 0.0F);
				Debug.DrawRay (transform.position, newDir, Color.red);
				transform.rotation = Quaternion.LookRotation (newDir);
				actionTime -= Time.deltaTime;
			}
			else if (Vector3.Distance (transform.position, origin.position) > 0.1f)
			{
				Vector3 targetDir = origin.position - transform.position;
				float rotate = rotateSpeed * Time.deltaTime;
				Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, rotate, 0.0F);
				Debug.DrawRay (transform.position, newDir, Color.red);
				transform.rotation = Quaternion.LookRotation (newDir);
				float move = movementSpeed * Time.deltaTime;
				transform.position = Vector3.MoveTowards(transform.position, origin.position, move);
			}
			else
			{
				Destroy(gameObject);
			}
		}
	}

	public void march(Transform newTarget, Transform newOrigin)
	{
		target = newTarget;
		origin = newOrigin;
	}
}
