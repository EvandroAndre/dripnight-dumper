using System;
using System.Collections.Generic;
using LitJson;

namespace COW;

public class ModifierRPNCal : IModeVariableBindingModifier
{
	public List<ModeVariable> ModeVariables;

	public List<string> Elements;

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

	public ModeVariable Cal()
	{
		return null;
	}
}
