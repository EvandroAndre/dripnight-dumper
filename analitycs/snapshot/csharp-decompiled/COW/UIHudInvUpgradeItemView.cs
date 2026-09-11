using GCommon;
using UnityEngine;

namespace COW;

public class UIHudInvUpgradeItemView : UIBaseView
{
	public UISprite PreIcon;

	public UISprite TailIcon;

	public UILabel DescLabel;

	public UISprite LevelIcon;

	public GameObject Mask;

	public UIHudUpgradeGemStateItem GemGroup;

	public GameObject UnlockedHL;

	public GameObject TopLockLine;

	public GameObject BottomLockLine;

	public GameObject TopUnLockLine;

	public GameObject BottomUnLockLine;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
