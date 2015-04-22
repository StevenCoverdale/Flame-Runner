using UnityEngine;
using System.Collections;

public class ScoreHud : MonoBehaviour 
{
	float playerScore = 0;
	float Timer = 10;
	float currentTime = 0;
	public Color color1 = Color.red;
	public Color color2 = Color.blue;

	Camera camera;
	void Start()
	{
		camera = GetComponent<Camera>();
		camera.clearFlags = CameraClearFlags.SolidColor;
	}
	// Update is called once per frame
	void Update () 
	{
		playerScore += Time.deltaTime;
		//if( currentTime >= Timer)
		//{
			//currentTime = 0;
			float t = Mathf.PingPong(Time.time, Timer) / Timer;
			camera.backgroundColor = Color.Lerp(color1, color2, t);
		//}
		//currentTime++;
	}
	public void IncreaseScore(int amount)
	{
		playerScore += amount;
	}
	void OnGUI()
	{
		GUI.Label(new Rect(10,10,100,30), "Score: " + (int)(playerScore)+ "s");
	}

}
