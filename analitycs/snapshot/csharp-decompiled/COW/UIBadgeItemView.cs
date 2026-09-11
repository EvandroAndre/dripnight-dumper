using GCommon;
using UnityEngine;

namespace COW;

public class UIBadgeItemView : UIBaseView
{
	public UISprite BadgeSprite;

	public GameObject BadgeBorder;

	public GameObject BadgeLock;

	public GameObject BadgeUsed;

	public UIToggleButton BadegItemBtn;

	public UILabel BadegCountdownLabel;

	public UICountDownLabel UICountDownLabel;

	public GameObject SpecialEffects;

	public GameObject UnLock;

	public UILabel BadgeLockLv;

	public UINetworkTexture BadgeCDN;

	public UISprite BadgeFrameL;

	public UISprite BadgeFrameR;

	public UISprite BadgeSpriteLocked;

	public GameObject BadgeFrameLocked;

	public UISprite BadgeFrameRLocked;

	public UISprite BadgeFrameLLocked;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
