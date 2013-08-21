using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	public float move_speed = 5.0f;
	public float jump_height = 10;
	tk2dSprite sprite;
	
	float lastNetworkTime = 0f;
	
	Vector3 LastPosition = Vector3.zero;
	Vector3 NextPosition = Vector3.zero;
	// Use this for initialization
	void Start () {
		sprite = GetComponent<tk2dSprite>();
	}
	
	// Update is called once per frame
	void Update () {

		
	}
	
	void FixedUpdate()
	{
		
	}
	
	/*void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
	{
		Debug.Log ("HELLO!");
		if (stream.isWriting)
		{
			Vector3 pos = this.transform.localPosition;
			Quaternion rot = this.transform.rotation;
			stream.Serialize(ref pos);
			stream.Serialize(ref rot);
		}
		else
		{
			Vector3 pos = Vector3.zero;
			Quaternion rot = Quaternion.identity;
			
			stream.Serialize(ref pos);
			stream.Serialize(ref rot);
			
			
			LastPosition = this.transform.position;
			NextPosition = pos;
			
			//lastNetworkTime;
		}
	}*/
}
