using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public float speed = 500;
	public float damage = 3;
	// Use this for initialization
	void Start () {
		var rb = GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;
		Destroy (gameObject, 2.0f);
	}

	void OnCollisionEnter(Collision info) {
		var target = info.collider.GetComponent<Destructible> ();
		if (target)
			target.Damage (damage);
		Destroy (gameObject);
	}
}
