using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour 
{
	public Transform grip;
	public Vector3 rightOffset;
	void OnControllerColliderHit(ControllerColliderHit other)
	{
		var item = other.gameObject.GetComponent<Item> ();
		if (item!=null) 
		{
			item.transform.SetParent (grip);
			item.transform.localRotation = Quaternion.identity;
			item.transform.localPosition = rightOffset;
			Equip (item);
		}
	}
	void Equip(Item selection)
	{
		foreach (var item in GetComponentsInChildren<Item>(true)) 
		{
			item.gameObject.SetActive (item == selection);
		}
	}
	public void EquipNext()
	{
		Item[] carried = GetComponentsInChildren<Item>(true);
		if(carried.Length <=0) return;
		for (int position = 0;position < carried.Length;++position)
		{
			if(carried[position].gameObject.activeSelf)
			{
				Equip(carried[++position % carried.Length]);
				return;
			}
		}
		Equip(carried[0]);
	}
	public void EquipPrevious()
	{
		Item[] carried = GetComponentsInChildren<Item>(true);
		if(carried.Length <=0) return;
		System.Array.Reverse (carried);
		for (int position = 0;position < carried.Length;++position)
		{
			if(carried[position].gameObject.activeSelf)
			{
				Equip(carried[++position % carried.Length]);
				return;
			}
		}
		Equip(carried[0]);
	}
}
