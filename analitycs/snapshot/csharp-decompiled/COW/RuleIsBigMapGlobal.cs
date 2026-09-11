using LitJson;
using UnityEngine;

namespace COW;

public class RuleIsBigMapGlobal : IDefalutVariableInternalRule
{
	private string m_value;

	public bool FromJsonData(JsonData jsonData)
	{
		return false;
	}

	public bool TryGetBoolDefaultValueByRule(ModeVariable variable)
	{
		return false;
	}

	public int TryGetIntDefaultValueByRule(ModeVariable variable)
	{
		return 0;
	}

	public float TryGetFloatDefaultValueByRule(ModeVariable variable)
	{
		return 0f;
	}

	public Vector3 TryGetVector3DefaultValueByRule(ModeVariable variable)
	{
		return default(Vector3);
	}
}
