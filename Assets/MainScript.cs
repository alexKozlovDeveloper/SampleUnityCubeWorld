using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        MapGenerator gen = new MapGenerator();

	    var map = gen.GetMap();


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
