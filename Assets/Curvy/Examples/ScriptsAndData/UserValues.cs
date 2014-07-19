using UnityEngine;
using System.Collections;

/*
 * This script demonstrates the usage of UserValues:
 * 
 * Here we use the x value of the UserValue to scale the cube
 * 
 */
/// <summary>
/// Example of how to work with User Values
/// </summary>
public class UserValues : MonoBehaviour {
    
    SplineWalker walkerScript;

	// Use this for initialization
	void Start () {
        walkerScript = GetComponent<SplineWalker>();
	}
	
	// Update is called once per frame
	void Update () {
        if (walkerScript) 
            transform.localScale = walkerScript.Spline.InterpolateUserValue(walkerScript.TF, 0);
	}
}
