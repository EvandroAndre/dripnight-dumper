using System.Collections.Generic;
using COW.GamePlay;

public class CustomCuverPathWayPointAttributeConfig : ItemFunctionAttributeBaseConfig
{
	public string EditPointTitle;

	public string AddPointButtonIcon;

	private SceneEditObjectCustomCurvePathWayPoint editObj;

	public override List<ItemFunctionUIData> GetUIData(SceneEditObjectBase objBase)
	{
		return null;
	}

	public void OnAddButtonClick()
	{
	}
}
