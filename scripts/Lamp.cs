using UnityEngine;
using System.Collections;

public class Lamp:CGeneratable {
	Light lightComp;
	public override void instant(GameObject prefab, Vector3 position){
		base.instant(prefab, position);
		GameObject lightGameObject = new GameObject("The Light");
    lightComp = lightGameObject.AddComponent<Light>();
		lightComp.color = Color.white;
		lightComp.range = 30;
		lightComp.intensity = 1.5f;
		lightComp.shadowStrength = 0.4f;
		lightGameObject.transform.parent = item.transform;
		lightComp.shadows = LightShadows.Soft;
		lightGameObject.transform.position = item.transform.position +  new Vector3(0, 3.4f, 0);
	}
	public override void generateStart(){
		setBox();
	}
	public override void populateTimeline(){

	}
	// Update is called once per frame
	void Update () {

	}
}
