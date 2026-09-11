using System;
using LitJson;

namespace COW;

public interface IModeVariableLogicOperate
{
	bool FromJsonData(ModeVariables contextVariables, JsonData jsonData);

	void AddDataChanged(Action callback);

	void RemoveDataChanged(Action callback);

	void CleanDataChanged();

	void SaveValue();
}
