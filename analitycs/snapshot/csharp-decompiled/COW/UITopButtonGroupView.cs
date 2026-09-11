using GCommon;
using UnityEngine;

namespace COW;

public class UITopButtonGroupView : UIBaseView
{
	public UIWidget Root;

	public UITable NaviPage;

	public UIButton BtnSettingInNaviPage;

	public UIButton HelpBtn;

	public UILabel title;

	public UIButton leaveBtn;

	public UISprite ButtonBgSprite;

	public UISprite ButtonClose;

	public UISprite NormalExchangeSprite;

	public UISprite ExchangeTokenSprite;

	public UIButton ExchangeStoreBtn;

	public UISprite Token1;

	public UILabel Token1Label;

	public GameObject Token1TimeIcon;

	public UIButton Token1Btn;

	public UISprite Token2;

	public UILabel Token2Label;

	public GameObject Token2TimeIcon;

	public UIButton Token2Btn;

	public Transform GotoTokenRoot;

	public UITable GotoTokenTable;

	public GameObject ExchangeStore;

	public UISprite Side;

	public Animation main;

	public UIWidget Token1Space;

	public UIWidget Token2Space;

	public Transform LobbyV2;

	public UIWidget Token1GuideWidget;

	public GameObject PrivilegeIcon;

	public Transform GachaCoupons;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
