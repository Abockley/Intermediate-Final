using UnityEngine;
using System.Collections;

public class Gun2 : MonoBehaviour {
	public Rigidbody bullet;
	public Vector3 muzzle;
	int count = 0;

	void Fire2 () 
	{
		if (isActiveAndEnabled)
		{
			Instantiate (bullet, transform.TransformPoint (muzzle), transform.rotation);
		}
	}
}
