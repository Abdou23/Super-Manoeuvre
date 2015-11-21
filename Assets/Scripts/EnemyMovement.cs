using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float speed = 2;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float x = -1 * speed * Time.deltaTime;
		transform.Translate(-Vector2.right * speed * Time.deltaTime);
	}
}
