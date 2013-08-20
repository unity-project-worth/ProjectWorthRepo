using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	public float move_speed = 5.0f;
	public float jump_height = 10;
	tk2dSprite sprite;
	// Use this for initialization
	void Start () {
		sprite = GetComponent<tk2dSprite>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W))
		{
			//Jump!
			rigidbody.velocity += Vector3.up * jump_height;
			Debug.Log ("Jump!");
		}
		if (Input.GetKey(KeyCode.D))
		{
			//Move Right
			this.transform.localPosition += new Vector3(move_speed * Time.deltaTime, 0, 0);
			sprite.FlipX = false;
		}
		
		if (Input.GetKey (KeyCode.A))
		{
			sprite.FlipX = true;
			this.transform.localPosition += new Vector3(-move_speed * Time.deltaTime, 0, 0);
		}
		


	}
	
	void FixedUpdate()
	{
		
	}
}
