using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaExtraListItemView : UIBaseView
{
	public UIButton ItemBtn;

	public UIProgressBar ItemNormalBgYellowPx;

	public GameObject ItemLock;

	public UILabel UIItemLabelLocked;

	public GameObject TreasureBoxNormal;

	public UISprite ItemIconReceived;

	public GameObject ItemUnLock;

	public UILabel UIItemLabelUnlock;

	public GameObject TreasureBoxSelected;

	public UISprite ItemIcon;

	public Animation ItemIconAnim;

	public GameObject ItemIconHightLight;

	public Transform ExtraRewardPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
