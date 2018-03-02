using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour {

	// Use this for initialization

	public Transform player;
	public Transform basgauche;
	public Transform basdroite;
	public Transform hautgauche;
	public Transform hautdroite;
	
	
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (player.transform.position.x < basdroite.position.x && player.transform.position.x > basgauche.position.x && player.transform.position.z<basdroite.position.z)
		{
			
		}
	}
}
