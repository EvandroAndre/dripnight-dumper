using GCommon;
using UnityEngine;

namespace COW;

public class UIEVOGunPrivilegeToggleView : UIBaseView
{
	public UIWidget ToggleWidget;

	public UIToggleButtonGroup SoundToggleGroup;

	public UIToggleButton OriginalToggleBtn;

	public UIToggleButton SpecialToggleBtn;

	public GameObject HighLight;

	public UISprite TitleIcon;

	public UILabel SoundTitleLabel;

	public UIButton ClickBtn;

	public GameObject New;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
