using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLoadoutSupportBuffSlotView : UIBaseView
{
	public GameObject FilledState;

	public GameObject LockedState;

	public GameObject CanUnlockedState;

	public UIButton BtnUnlock;

	public UILabel LabelMoneyNormal;

	public UISprite SpriteBuff;

	public GameObject EmptyState;

	public GameObject VFXChoose;

	public UIButton BtnChoose;

	public UILabel LabelDesc;

	public UIButton BtnCancel;

	public UILabel LabelMoneyDisable;

	public GameObject BtnUnlockDisable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
