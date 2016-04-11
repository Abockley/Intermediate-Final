using UnityEngine;
using System.Collections;

public class FireControl : MonoBehaviour {
private int count = 0;

void Update () {
		if (Input.GetButton ("Fire1")) {
			count++;
			if (count == 2) {
				BroadcastMessage ("Fire", SendMessageOptions.DontRequireReceiver);
				count = 0;
			}
		} 
		if (Input.GetButtonDown ("Fire1")) {
			BroadcastMessage ("Fire2", SendMessageOptions.DontRequireReceiver);
		}
		else if (Input.GetButtonDown ("Fire3")) {
			GetComponent<Inventory> ().EquipNext ();
		}
		else if (Input.GetButtonDown ("Fire2")) {
			GetComponent<Inventory> ().EquipPrevious ();
		}
	}
}
