using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	public GameObject bullet;
	public float speed = 5;

	private Rigidbody2D myBody;
	private Vector2 offsetPosition;
	private float offset;
	// Use this for initialization
	void Start () 
	{
		myBody = GetComponent<Rigidbody2D>();

		offset = gameObject.transform.localScale.y + 0.5f;
	}

	void Update ()
	{
		bool isShooting = CrossPlatformInputManager.GetButtonDown("Shoot");
		offsetPosition = new Vector2(transform.position.x + offset, transform.position.y);
		if (isShooting)
		{
			Instantiate(bullet, offsetPosition, bullet.transform.rotation);
		}
	}

	void FixedUpdate () 
	{
		Vector2 force = new Vector2(0, CrossPlatformInputManager.GetAxis("Vertical") * speed);
		myBody.AddForce(force);
	}
}
