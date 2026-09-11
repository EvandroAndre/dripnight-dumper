using System.Collections.Generic;
using COW.GamePlay;

public class CustomPointFunctionAttributeConfig : ItemFunctionAttributeBaseConfig
{
	public string EditPointTitle;

	public string RemovePointButtonIcon;

	public string AddPointButtonIcon;

	private SceneEditObjectCustomPointV2 editObj;

	public override List<ItemFunctionUIData> GetUIData(SceneEditObjectBase objBase)
	{
		return null;
	}

	private void OnAddButtonClick()
	{
	}

	private void OnRemoveButtonClick()
	{
	}
}
