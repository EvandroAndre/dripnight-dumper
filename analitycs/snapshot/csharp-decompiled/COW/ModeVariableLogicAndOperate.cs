using System;
using LitJson;

namespace COW;

public class ModeVariableLogicAndOperate : IModeVariableLogicOperate
{
	public ModeVariableBinding Left;

	public ModeVariableBinding Right;

	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return false;
	}

	public void AddDataChanged(Action callback)
	{
	}

	public void RemoveDataChanged(Action callback)
	{
	}

	public void CleanDataChanged()
	{
	}

	public void SaveValue()
	{
	}
}
