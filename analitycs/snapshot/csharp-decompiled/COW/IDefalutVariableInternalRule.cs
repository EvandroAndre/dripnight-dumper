using LitJson;
using UnityEngine;

namespace COW;

public interface IDefalutVariableInternalRule
{
	bool FromJsonData(JsonData jsonData);

	bool TryGetBoolDefaultValueByRule(ModeVariable variable);

	int TryGetIntDefaultValueByRule(ModeVariable variable);

	float TryGetFloatDefaultValueByRule(ModeVariable variable);

	Vector3 TryGetVector3DefaultValueByRule(ModeVariable variable);
}
