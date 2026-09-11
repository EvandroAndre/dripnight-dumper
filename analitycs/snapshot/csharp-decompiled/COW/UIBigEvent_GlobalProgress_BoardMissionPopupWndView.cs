using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_GlobalProgress_BoardMissionPopupWndView : UIBaseView
{
	public UITable MissionList;

	public UIScrollView MissionScrollView;

	public UILabel LabelRefreshTime;

	public UIButton BtnClameAll;

	public UILabel AllClaimedBtnLabel;

	public UINetworkTexture AllClaimedBtnCDN;

	public UINetworkTexture TextureBg;

	public UINetworkTexture RefreshTimeIcon;

	public UINetworkTexture TextureBarBg;

	public UINetworkTexture MissionHeadArrow;

	public UINetworkTexture MissionTailArrow;

	public UILabel ExchangeStoreLabel;

	public UINetworkTexture ExchangeStoreCDN;

	public GameObject SpriteRedDot;

	public UIButton BtnExchange;

	public UINetworkTexture MissionTitleCDN;

	public GameObject VFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
