using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {

	private PlayerMover m_Character;
	private bool m_Jump;

	private void Awake()
	{
		m_Character = GetComponent<PlayerMover> ();
	}
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	}
	void FixedUpdate()
	{
		// Read the inputs.
		float h =Input.GetAxis ("Horizontal");
		// Pass all parameters to the character control script.
		m_Character.Move(h);
	}
}
