using UnityEngine;

namespace COW;

public class CommonGuideSetting
{
	public const int PERMANENT_HINT = -1;

	public TutorialUIType DisplayType;

	public float HideDelay;

	public string HintText;

	public string ParamText;

	public Vector3 HandFrom;

	public Vector3 HandTo;

	public bool UseLocalPosKeepInScreen;

	public CommonGuideSetting()
	{
	}

	public CommonGuideSetting(TutorialUIType dType, string hint, string param = null, float delay = 0f, Vector3 handFrom = default(Vector3), Vector3 handTo = default(Vector3))
	{
	}
}
