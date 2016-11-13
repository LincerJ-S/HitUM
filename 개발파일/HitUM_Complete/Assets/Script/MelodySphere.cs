using UnityEngine;
using System.Collections;

public class MelodySphere : MonoBehaviour {

	public ParticleSystem effect;
	private GameController gC;
	void Start(){
		GameObject gCO = GameObject.FindWithTag ("GameController");
		if (gCO != null) {
			gC = gCO.GetComponent<GameController> ();
		} else {
			Debug.Log ("못찾겠다.");
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Note") {
			Destroy (this.gameObject);
			Destroy (other.gameObject);
			gC.AddScore (100);
			Instantiate (effect, transform.position, Quaternion.identity);
		}
		if (other.tag == "Shooter") {
			Destroy (this.gameObject);
			gC.AttackHeart ();
			if (gC.GetHeart () == 0) {
				Destroy (other.gameObject);
				Debug.Log ("게임종료");
			}
		}
	}
}
