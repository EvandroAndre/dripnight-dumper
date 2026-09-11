using UnityEngine;

namespace COW;

public class UIPosCurve : MonoBehaviour
{
	public AnimationCurve posXCurve;

	public AnimationCurve posYCurve;

	public AnimationCurve posZCurve;

	public Vector3 startLocalPos;

	public Vector3 endLocalPos;

	public void Evaluate(float amountValue)
	{
	}

	public Vector3 GetEvaluateValue(float amountValue)
	{
		return default(Vector3);
	}
}
