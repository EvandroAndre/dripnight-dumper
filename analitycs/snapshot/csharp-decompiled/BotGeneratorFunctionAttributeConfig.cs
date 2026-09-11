using System.Collections.Generic;
using COW.GamePlay;

public class BotGeneratorFunctionAttributeConfig : ItemFunctionAttributeBaseConfig
{
	public string EditBotTitle;

	public string EditButtonIcon;

	public string EditBotDetailWindowConfig;

	public string EditBotDetailWindowVariableConfig;

	private SceneEditObjectVariableAttrBase editObject;

	private FKMEPHCOMIG mSettingData;

	public FKMEPHCOMIG SettingData => null;

	public override List<ItemFunctionUIData> GetUIData(SceneEditObjectBase objBase)
	{
		return null;
	}

	protected virtual uint GetItemType()
	{
		return 0u;
	}

	private void OnEditButtonClick()
	{
	}

	public void OnPickedObject(SceneEditObjectBase pickedObj)
	{
	}

	public override void Clear()
	{
	}
}
