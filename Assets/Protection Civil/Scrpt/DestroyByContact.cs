using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	//public GameObject explosion;
	//public GameObject playerExplosion;
	public int scoreValue;
	public int dmg;

	public float destroyTime;
	private GameController gameController;

	public float punchPower;
	private Rigidbody2D rb;
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null){
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		else if (gameController == null){
			Debug.Log ("Cannot find 'GameController' script");
		}

		rb = GetComponent<Rigidbody2D>();
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Coup" || other.gameObject.tag == "Mob"){
			//Instantiate (explosion, transform.position, transform.rotation);
			gameController.AddScore (scoreValue);
			Destroy(gameObject, destroyTime);

			Vector2 forceAdd;
			if (other.gameObject.tag == "Coup")
				forceAdd = new Vector2 (punchPower * 100, Random.Range (-punchPower, punchPower) * 100);
			else
				forceAdd = other.rigidbody.velocity*10;
			
			rb.AddForce (forceAdd);

			return;

		}

		if (other.gameObject.tag == "Civil"){
			//Instantiate (explosion, transform.position, transform.rotation);
			gameController.dmgCivil (dmg);
			Destroy(gameObject);
			return;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{/*
		if (other.tag == "Civil"){
			//Instantiate (explosion, transform.position, transform.rotation);
			gameController.dmgCivil (dmg);
			Destroy(gameObject);
			return;
		}*/
		/*
		if (other.tag == "Coup"){
			//Instantiate (explosion, transform.position, transform.rotation);
			gameController.AddScore (scoreValue);
			Destroy(gameObject, destroyTime);
			return;
		}*/
	}
}
