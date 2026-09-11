using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHighLightNewSettingCtrlView : UIBaseView
{
	public UIPanel SettingPanel;

	public GameObject offest;

	public UITable SettngTable;

	public UIToggleButtonGroup SettngToggleGroup;

	public UIToggleButton ToggleMultiKill;

	public UIToggleButton ToggleMultiHeadshot;

	public UIToggleButton ToggleAllMatch;

	public UIToggleButton ToggleGuaranteedKill;

	public UIToggleButton ToggleCSAce;

	public UILabel MultiKillLabelSelect;

	public UILabel MultiKillLabelUnSelect;

	public UILabel MultiHeadshotLabelSelect;

	public UILabel MultiHeadshotLabelUnSelect;

	public UIToggleButton ToggleEpicKill;

	public UISprite CSAceSelectIcon;

	public UISprite CSAceUnSelectIcon;

	public UISprite Icon_Headshots01;

	public UISprite Icon_Headshots02;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
