using UnityEngine;
using System.Collections;

interface StoryEvent {
		void run();
}

public abstract class StoryObject :MonoBehaviour{
	StoryEvent[] events;
	int current;
	public abstract void populateTimeline();
	public void nextEvent(){
		events[current].run();
		current++;
	}
}
