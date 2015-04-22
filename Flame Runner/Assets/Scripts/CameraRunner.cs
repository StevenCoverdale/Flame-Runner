using UnityEngine;
using System.Collections;

public class CameraRunner : MonoBehaviour 
{
	public int m_cameraOffset = 5;
	public Transform m_player;
	// Update is called once per frame
	void Update () 
	{
		//if(m_player.position.y >= -3)
			//if(m_player.position.y <= 7)
				transform.position = new Vector3(m_player.position.x + m_cameraOffset ,2,-10);
		//else
		//transform.position = new Vector3(m_player.position.x + m_cameraOffset ,7,-10);
	}
}
