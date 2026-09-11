using GCommon;
using UnityEngine;

namespace COW;

public class UIAnniversaryRemindWndView : UIBaseView
{
	public GameObject UIAnniversaryRemindWnd;

	public UILabel Title;

	public UILabel Dear;

	public GameObject ItemPos;

	public UIButton ClaimBtn;

	public UINetworkTexture BG;

	public UIButton CloseBtn;

	public GameObject ShareBG;

	public UILabel Content;

	public UILabel RewardContent;

	public UILabel Date;

	public UIButton ShareBtn;

	public UINetworkTexture Number;

	public UINetworkTexture Duck;

	public UINetworkTexture Close;

	public UINetworkTexture Open;

	public UINetworkTexture Cover;

	public Animation main;

	public GameObject Gift;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
