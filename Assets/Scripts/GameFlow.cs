using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour {

	public Transform grassblock;

	void Start () {

		Instantiate (grassblock, new Vector3 (-3, 0, -5), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (-2, 0, -5), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (-1, 0, -5), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (0, 0, -5), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (3, 0, -5), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (2, 0, -5), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (1, 0, -5), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (4, 0, -5), grassblock.rotation);

		Instantiate (grassblock, new Vector3 (-3, 1, -4), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (-2, 1, -4), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (-1, 1, -4), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (0, 1, -4), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (3, 1, -4), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (2, 1, -4), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (1, 1, -4), grassblock.rotation);
		Instantiate (grassblock, new Vector3 (4, 1, -4), grassblock.rotation);
		
	}

	void Update () {
		
	}
}