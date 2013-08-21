using UnityEngine;
using System.Collections;

public class NetworkingTest : MonoBehaviour {
	public GameObject ToInstantiate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI()
	{
		if (GUI.Button (new Rect(0, Screen.height *.2f, 100, 25), "Create Server"))
		{
			Network.InitializeServer(10, 8000, true);
			Network.Instantiate(ToInstantiate, new Vector3(26, 20, 0), Quaternion.identity, 0);
		}
		
		if (GUI.Button (new Rect(0, Screen.height * .25f, 100, 25), "Join Server"))
		{
			Network.Connect("127.0.0.1", 8000);
			
		}
	}
	
	void OnConnectedToServer()
	{
		Network.Instantiate(ToInstantiate, new Vector3(26, 20, 0), Quaternion.identity, 0);
	}
}