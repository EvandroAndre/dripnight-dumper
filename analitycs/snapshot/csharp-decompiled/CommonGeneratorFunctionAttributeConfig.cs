using System.Collections.Generic;
using COW.GamePlay;

public class CommonGeneratorFunctionAttributeConfig : ItemFunctionAttributeBaseConfig
{
	public string EditTitle;

	public string EditButtonIcon;

	public int ShowIndex;

	private string mCurrentVFXResID;

	public override void OnCreateObject(SceneEditObjectBase obj)
	{
	}

	public override List<ItemFunctionUIData> GetUIData(SceneEditObjectBase objBase)
	{
		return null;
	}
}
