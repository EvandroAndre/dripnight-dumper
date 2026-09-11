using System;
using LitJson;

namespace COW;

public class ModifierRegionSwitch : IModeVariableBindingModifier
{
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
}
