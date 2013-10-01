using UnityEngine;
using System.Collections;
using System.Collections.Generic; // YOU NEED THIS LINE TO USE LISTS

public class FishGod : MonoBehaviour {
	public Fish fishBlueprint;
	public Fish otherBlueprint;
	public int fishCount = 100; 
	public List <Fish> fishList = new List<Fish>();
	
	// Use this for initialization
	void Start () {
		// temporary variable
		int currentFishCounter = 0;
		while(currentFishCounter < fishCount){
			//spawn a fish
			int randomNumber = Random.Range(0,10);
			if (randomNumber < 5){
			Vector3 fishPosition = Random.insideUnitSphere * 100f;
			Fish newFish = Instantiate ( fishBlueprint, fishPosition, Quaternion.identity) as Fish;
			fishList.Add (newFish);
			currentFishCounter++;
			} else {Vector3 fishPosition = Random.insideUnitSphere * 100f;
			Fish newFish = Instantiate (otherBlueprint, fishPosition, Quaternion.identity) as Fish;
			fishList.Add (newFish);
			currentFishCounter++;
			}
	}	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			foreach (Fish currentFish in fishList) {
				currentFish.destination = Vector3.zero;
			}
		}
	}
}


