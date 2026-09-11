using GCommon;
using UnityEngine;

namespace COW;

public class UIClanPrivilegeClaimWindowView : UIBaseView
{
	public UILabel Title;

	public UILabel PreviewClanName;

	public GameObject SponsoredContainer;

	public UILabel SponsoredLabel;

	public GameObject CallsignPviot;

	public UIButton ShareBtn;

	public GameObject LeftOldSeat;

	public UIButton EquipBtn;

	public GameObject UnableToEquipBtnBG;

	public GameObject AbleToEquipBtnBG;

	public UIButton ClaimBtn;

	public GameObject UnableToClaimBtnBG;

	public GameObject AbleToClaimBtnBG;

	public GameObject UnableActivenessContainer;

	public UILabel UnableActivenessNum;

	public UINetworkTexture ForeBG;

	public UIButton CloseBtn;

	public UITable GloryTagContainer;

	public GameObject HightLightTag;

	public UILabel HightLightLabel;

	public GameObject RoleTag;

	public UILabel RoleLabel;

	public GameObject BriefBoxPos;

	public GameObject DontShowContainer;

	public UIToggle DontShowBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
