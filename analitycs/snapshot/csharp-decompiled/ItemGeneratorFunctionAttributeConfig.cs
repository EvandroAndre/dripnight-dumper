using System.Collections.Generic;
using COW.GamePlay;

public class ItemGeneratorFunctionAttributeConfig : ItemFunctionAttributeBaseConfig
{
	public string EditTitle;

	public string EditButtonIcon;

	public int ShowIndex;

	private int mItemID;

	private SceneEditObjectBase mCurrentObj;

	private ItemFunctionUIData mCurrentFunctionUIData;

	public override void OnCreateObject(SceneEditObjectBase obj)
	{
	}

	public override List<ItemFunctionUIData> GetUIData(SceneEditObjectBase objBase)
	{
		return null;
	}

	private void GetShowLabel(int itemID, ref string showLabel, ref string entityName)
	{
	}

	private void OnEditButtonClick()
	{
	}

	private void OnFinalSelected(string resID, int itemID)
	{
	}

	private string UpdateItemID(int itemID, SceneEditObjectBase obj, bool forceUpdate = false)
	{
		return null;
	}
}
