using UnityEngine;
using System.Collections;

public class MoveNote : MonoBehaviour {

	private Rigidbody rb;
	public float speed = 100.0f;
	void Start () {
		rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
