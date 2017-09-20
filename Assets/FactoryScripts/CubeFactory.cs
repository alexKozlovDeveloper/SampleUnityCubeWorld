using UnityEngine;
using System.Collections;


public class CubeFactory : MonoBehaviour
{
    public static CubeFactory Instance { get; private set; }

    public GameObject DirtCubePrefab;
    public GameObject GrassCubePrefab;
    public GameObject RockCubePrefab;

    // Use this for initialization
    void Start ()
    {
        Instance = this;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
