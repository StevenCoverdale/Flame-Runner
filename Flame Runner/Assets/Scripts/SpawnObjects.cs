using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour 
{
	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public Transform m_player;

	private float m_xPos;
	// Use this for initialization
	void Start () 
	{
		m_xPos = m_player.position.x + this.transform.position.x;
		Spawn();
	}
	void Spawn()
	{
		Instantiate(obj[Random.Range (0, obj.GetLength(0))],transform.position, Quaternion.identity);
		Invoke( "Spawn", Random.Range(spawnMin,spawnMax));
	}
	void Update () 
	{
		transform.position = new Vector3(m_player.transform.position.x + m_xPos ,this.transform.position.y,0);
	}
}
