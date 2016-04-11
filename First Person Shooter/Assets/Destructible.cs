using UnityEngine;
using System.Collections;

public class Destructible : MonoBehaviour {
	public float health = 10;

	public float Damage(float amount) {
		health -= amount;
		if (health <= 0)
			Destroy (gameObject); 
		return health;
	}
}
