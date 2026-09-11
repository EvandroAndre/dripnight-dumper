using GCommon;
using UnityEngine;

namespace COW;

public class UIClanActiveExchangeMallView : UIBaseView
{
	public GameObject AbleToBuyBtnBG;

	public GameObject UnableToBuyBtnBG;

	public UILabel UnableBuyLabel;

	public UIButton BuyBtn;

	public UIWidget PreviewPos;

	public UIEasyList ExchangeMallEasyList;

	public UIEasyList ExchangeMallShortEasyList;

	public GameObject CommonState;

	public GameObject PrivilegeState;

	public GameObject TopShow;

	public UIButton TopShowBtn;

	public GameObject HighLight;

	public UISprite EffectingTag;

	public UILabel TitleLabel;

	public GameObject PricingContainer;

	public UILabel PricingLabel;

	public UISprite PrivilegeIcon;

	public UINetworkTexture PrivilegeCDN;

	public GameObject PrivilegePreview;

	public UIButton HelpBtn;

	public GameObject VacantSeat;

	public GameObject CallsignPviot;

	public UIButton SponsoredDetailsGotoBtn;

	public GameObject SponsoredDetails;

	public UIButton EquipBtn;

	public GameObject UnableToEquipBtnBG;

	public UILabel UnableEquipLabel;

	public GameObject AbleToEquipBtnBG;

	public UILabel EquipBtnLabel;

	public GameObject CountDown;

	public GameObject LeftOldSeat;

	public UIButton ShareBtn;

	public UILabel BuyBtnLabel;

	public UILabel ClanName;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
