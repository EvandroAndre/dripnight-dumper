using GCommon;
using UnityEngine;

namespace COW;

public class UINinthSYSGameplayView : UIBaseView
{
	public UIButton BtnClose;

	public UIToggleButton CSToggleBtn;

	public UIButton LeftBtn;

	public UIButton RightBtn;

	public GameObject DeathBoxReviveContainer;

	public GameObject TeamZoneTaskContainer;

	public GameObject PlaneRouteContainer;

	public GameObject WeaponAwakenContainer;

	public GameObject PowerCharacterContainer;

	public GameObject AbilityEnhancedAirdropContainer;

	public UIToggleButton BRToggleBtn;

	public UIToggleButtonGroup ToggleTab;

	public UIGrid SubTabGrid;

	public UIToggleButton CharacterToggleBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
