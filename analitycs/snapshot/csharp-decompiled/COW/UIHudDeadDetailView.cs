using GCommon;
using UnityEngine;

namespace COW;

public class UIHudDeadDetailView : UIBaseView
{
	public UILabel KillerName;

	public UIButton ReportBtn;

	public UIButton ExpandBtn;

	public GameObject ExpandIcon;

	public GameObject CollapseIcon;

	public UITable DetailContainer;

	public UIEffectSprite KillerSprite;

	public GameObject ClanContainer;

	public UILabel ClanName;

	public UISprite ClanFrame;

	public UINetworkTexture ClanCDN;

	public UISprite ClanLogo;

	public UISprite ReportIcon;

	public GameObject AccidentSprite;

	public Transform DetailClanTrans;

	public Transform DetailTrans;

	public UILabel MatchID;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	public GameObject KillerExtraInfoContainer;

	public UILabel KillerSFInfo;

	public UISprite KillerSFBg;

	public UISprite KillerSFLevel;

	public GameObject EmulatorIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
