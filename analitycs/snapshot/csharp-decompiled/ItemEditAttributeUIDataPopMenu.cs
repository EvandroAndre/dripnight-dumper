using System;
using System.Collections.Generic;

public class ItemEditAttributeUIDataPopMenu : ItemEditAttributeUIData
{
	private List<string> m_OptionShowTxtKey;

	private List<int> m_OptionValue;

	private int m_CurUIValue;

	private bool m_ShowButton;

	private string m_BtnIcon;

	private string m_TipTxtKey;

	private Action<int> m_ButtonCallBack;

	public List<string> OptionShowTxtKey => null;

	public List<int> OptionValue => null;

	public int CurUIValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool ShowButton => false;

	public string BtnIcon => null;

	public string TipTxtKey => null;

	public Action<int> ButtonCallBack => null;

	public override SceneEditItemAttributeUIType GetUIType()
	{
		return SceneEditItemAttributeUIType.ItemUIType_Sub_Input_Plus;
	}

	public void ScriptObjectDataToUIData(string attributeTitleNameKey, List<string> optionShowTxtKey, List<int> optionValue, int defaultValue, bool showButton = false, string btnIcon = "", Action<int> btnCallback = null, string tipTexKey = null)
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
