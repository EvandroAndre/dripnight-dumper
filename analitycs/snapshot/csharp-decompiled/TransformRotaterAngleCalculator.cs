using UnityEngine;

internal interface TransformRotaterAngleCalculator
{
	Vector3 CalculateAnglesInLocalSpace(Vector3 current, Vector3 target, float maxRad);
}
