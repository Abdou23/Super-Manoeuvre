using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject enemy;


	private float randomSpawnTime;
	// Use this for initialization
	void Start () 
	{
		Invoke("CreateEnemy", 2);
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void CreateEnemy()
	{
		randomSpawnTime = Random.Range(1, 3);

		Instantiate(enemy, transform.position, enemy.transform.rotation);

		Invoke("CreateEnemy", randomSpawnTime);
	}
}
