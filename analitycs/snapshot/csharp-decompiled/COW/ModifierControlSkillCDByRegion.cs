using System;
using LitJson;

namespace COW;

public class ModifierControlSkillCDByRegion : IModeVariableBindingModifier
{
	public string SkillType;

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
