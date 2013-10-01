using UnityEngine;
using System.Collections;

public class HomeworkQuestions : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time> 50f) {
			cam1.enabled = false;
			cam2.enabled = true; }
	
	}
}
