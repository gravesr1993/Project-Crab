using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {

	private Rigidbody2D m_Rigidbody2D;
	public float m_MaxSpeed;
	// Use this for initialization
	void Start () 
	{
		m_MaxSpeed = 10;
		m_Rigidbody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void FixedUpdate()
	{
	}
	public void Move(float move)
	{
		m_Rigidbody2D.velocity = new Vector2(move*m_MaxSpeed, m_Rigidbody2D.velocity.y);
	}
}
