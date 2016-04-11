using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	public Rigidbody bullet;
	public Vector3 muzzle;
	int count = 0;

	void Fire () 
	{
		if (isActiveAndEnabled)
		{
			count++;
			if (count == 3) 
			{
				Instantiate (bullet, transform.TransformPoint (muzzle), transform.rotation);
				count = 0;
			}
		}
	}
}
