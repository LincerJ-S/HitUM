using UnityEngine;
using System.Collections;

public class DestroyNote_Sphere : MonoBehaviour {
	public ParticleSystem destroyEffect;
	void  OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary"||other.tag =="Shooter"||other.tag == "Tile") {
			return;
		}
		Destroy (this.gameObject);
		Destroy (other.gameObject);
		Instantiate (destroyEffect, transform.position, Quaternion.identity);

	}
}
