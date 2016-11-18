using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public abstract class Generator<T>:MonoBehaviour where T:Generatable,new() {
	public GameObject prefab;
	public List<T> contents = new List<T>();
	private T temp;
	public abstract void generate();
	public void instant(Vector3 position){
		temp = new T();
		temp.instant(prefab, this.transform.position+position);
		temp.item.transform.parent = this.transform;
		contents.Add(temp);
	}


}
