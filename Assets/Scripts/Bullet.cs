using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed = 5;


	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector2.right * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D target)
	{
		Destroy(gameObject);
		Destroy(target.gameObject);
	}
}
