using GCommon;
using UnityEngine;

namespace COW;

public class UIVeteranV3SignRewardItemView : UIBaseView
{
	public GameObject ItemCon;

	public UILabel NormalItemTime;

	public UILabel SpecialItemTime;

	public GameObject LockTitle;

	public GameObject UnlockTitle;

	public UILabel LockDayLabel;

	public UILabel UnlockDayLabel;

	public UIButton ClaimBtn;

	public VFXCreateHelper SpecialState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
