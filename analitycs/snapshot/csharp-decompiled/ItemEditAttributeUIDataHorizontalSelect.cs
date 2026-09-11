using System.Collections.Generic;

public class ItemEditAttributeUIDataHorizontalSelect : ItemEditAttributeUIData
{
	private List<string> m_OptionShowTxtKey;

	private List<int> m_OptionValue;

	private int m_CurUIValue;

	private string m_TipTxtKey;

	public List<string> OptionShowTxtKey => null;

	public List<int> OptionValue => null;

	public int CurUIValue
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public string TipTxtKey => null;

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public void ScriptObjectDataToUIData(string attributeTitleNameKey, List<string> optionShowTxtKey, List<int> optionValue, int defaultValue, string tipTexKey = null)
	{
	}

	public override void UIChangeCallBack(object param, int valueOrder = 1)
	{
	}

	public override ItemEditAttributeCacheValueBase GetItemEditAttributeCacheValue()
	{
		return null;
	}
}
