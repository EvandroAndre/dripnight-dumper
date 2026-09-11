using System;
using System.Collections.Generic;
using LitJson;

namespace COW;

public class ModifierInIntArray : IModeVariableBindingModifier
{
	public List<int> values;

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
