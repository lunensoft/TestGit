using UnityEngine;
using System.Collections;

public class ClosestPoint : MonoBehaviour {
    public CurvySpline Target;
    public Transform TargetTransform;

    IEnumerator Start()
    {
        while (!Target.IsInitialized)
            yield return null;
    }
	
	// Update is called once per frame
	void Update () {
        if (Target && TargetTransform) {
            float tf = Target.GetNearestPointTF(transform.position);
            TargetTransform.position = Target.Interpolate(tf);
        }
	}
}
