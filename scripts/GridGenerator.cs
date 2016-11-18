using UnityEngine;
using System.Collections;
public abstract class GridGenerator<T> : Generator<T> where T:Generatable,new() {
	public float spaceX = 2, spaceY = 2;
	public int maxX = 4, maxY = 4;
	public override void generate(){
		for(int x  = 0; x < maxX;x++){
			for(int y = 0;y < maxY; y++){
				instant(new Vector3(x*spaceX, 0, y*spaceY));
			}
		}
	}
}
