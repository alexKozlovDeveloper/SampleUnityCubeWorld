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

    private GameObject GetCube(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        var cube = Instantiate(prefab, position, rotation) as GameObject;

        return cube;
    }

    public GameObject GetDirtBlock(Vector3 position, Quaternion rotation)
    {
        return GetCube(DirtCubePrefab, position, rotation);
    }

    public GameObject GetRockBlock(Vector3 position, Quaternion rotation)
    {
        return GetCube(RockCubePrefab, position, rotation);
    }

    public GameObject GetGrassBlock(Vector3 position, Quaternion rotation)
    {
        return GetCube(GrassCubePrefab, position, rotation);
    }
}
