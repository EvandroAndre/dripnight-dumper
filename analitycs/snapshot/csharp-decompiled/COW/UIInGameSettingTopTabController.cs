using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameSettingTopTabController : UIBaseController
{
	private UIInGameSettingTopTabView m_View;

	public UILabel SelectLabel;

	public UILabel UnselectLabel;

	public UIToggleButton ToggleBtn;

	public UISprite SelectedSprite;

	public Color SelectLabelDefaultColor;

	public Color UnSelectLabelDefaultColor;

	public UITipsNormalController m_tipsController;

	private SettingMainType SettingType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetSettingType(SettingMainType settingType)
	{
	}

	public SettingMainType GetSettingType()
	{
		return SettingMainType.None;
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
