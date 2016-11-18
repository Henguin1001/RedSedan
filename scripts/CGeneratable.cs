using UnityEngine;
using System.Collections;

public abstract class CGeneratable : Generatable{
	public void setBox(){
		item.AddComponent<BoxCollider>();
	}
}
