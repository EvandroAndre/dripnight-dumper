using System;
using LitJson;

namespace COW;

public interface IModeVariableBindingModifier
{
	bool FromJsonData(ModeVariables contextVariables, JsonData jsonData);

	void AddDataChanged(Action callback);

	void RemoveDataChanged(Action callback);

	void CleanDataChanged();
}
