using System.Collections.Generic;
using COW.GamePlay;

public class VFXFunctionAttributeConfig : ItemFunctionAttributeBaseConfig
{
	public string EditTitle;

	public string EditButtonIcon;

	public int ShowIndex;

	private string mCurrentVFXResID;

	private SceneEditObjectBase mCurrentObj;

	private ItemFunctionUIData mCurrentFunctionUIData;

	public override void OnCreateObject(SceneEditObjectBase obj)
	{
	}

	public override List<ItemFunctionUIData> GetUIData(SceneEditObjectBase objBase)
	{
		return null;
	}

	private string GetShowLabel(string resId)
	{
		return null;
	}

	private void OnEditButtonClick()
	{
	}

	private void OnFinalSelected(string resourceName, int itemID)
	{
	}
}
