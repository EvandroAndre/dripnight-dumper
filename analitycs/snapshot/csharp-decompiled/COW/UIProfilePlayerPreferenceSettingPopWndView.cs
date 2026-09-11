using GCommon;
using UnityEngine;

namespace COW;

public class UIProfilePlayerPreferenceSettingPopWndView : UIBaseView
{
	public GameObject TableToggle;

	public GameObject BasicSettingPanel;

	public UILabel NameLabel;

	public UIButton ChangeNameBtn;

	public UISprite LanguageSprite;

	public UIButton ChangeLanguageBtn;

	public Transform Sex;

	public Transform DefaultShow;

	public Transform OnLineTime;

	public Transform ActiveTime;

	public Transform ModePrefer;

	public UIToggleButtonGroup PregameInfoPanel;

	public GameObject WidgetPregameInfo_Preview;

	public Transform RootPlayerInfoPreview;

	public UILabel LabelTitlePregameInfoData;

	public UITable TablePregameInfoData;

	public GameObject WeaponPowerPanel;

	public Transform WeaponPowerPivot;

	public GameObject TitleShowPanel;

	public Transform TitleShowPivot;

	public Transform PrivilegeBadge;

	public UIGrid SettingGrid;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
