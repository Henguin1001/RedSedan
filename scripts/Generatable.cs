using UnityEngine;
using System.Collections;

public abstract class Generatable:StoryObject{
	public GameObject item;
	public abstract void generateStart();
	public virtual void instant(GameObject prefab, Vector3 position){
		item = (GameObject) Instantiate(prefab, position, Quaternion.identity);
		generateStart();
	}
}
