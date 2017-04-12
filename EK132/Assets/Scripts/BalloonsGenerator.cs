using UnityEngine;
using System.Collections;

public class BalloonsGenerator : MonoBehaviour {

	public GameObject redBalloon;
	public GameObject greenBalloon;
	public float density;


	// Use this for initialization
	void Start () {
		for (int i = 1; i <= 10; i++) {
			GameObject balloon;
			balloon = Random.value > 0.65f ? greenBalloon : redBalloon;
			Vector3 pos = randomUnitCube((float)i*2 - 10f);
			Instantiate (balloon, pos, Quaternion.identity);
		}
	}

	Vector3 randomUnitCube(float x){
		return new Vector3 (x, (density*(Random.value) - density/2f), 0f);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
