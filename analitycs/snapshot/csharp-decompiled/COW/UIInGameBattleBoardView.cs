using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameBattleBoardView : UIBaseView
{
	public GameObject TypeOneSinglePlayer;

	public UILabel TypeOneTitle;

	public GameObject TopPlayer;

	public UILabel PlayerNameLabel;

	public GameObject PlayerId;

	public UILabel PlayerIdLabel;

	public UITexture AvatarCDNTexture;

	public UINetworkTexture AvatarNetTexture;

	public GameObject UIFX_OnePlayer;

	public GameObject TypeTwoComparePlayer;

	public UILabel TypeTwoTitle;

	public GameObject LeftPlayerId;

	public UILabel LeftPlayerIdNameLabel;

	public UILabel LeftPlayerIdLabel;

	public UITexture LeftAvatarCDNTexture;

	public UINetworkTexture LeftAvatarNetTexture;

	public GameObject RightPlayerId;

	public UILabel RightPlayerNameLabel;

	public UILabel RightPlayerIdLabel;

	public UITexture RightAvatarCDNTexture;

	public UINetworkTexture RightAvatarNetTexture;

	public GameObject UIFX_TwoPlayer;

	public UINetworkTexture logo;

	public UINetworkTexture Comparelogo;

	public UIGrid PlayerDataGrid;

	public GameObject OrderOneContainer;

	public UILabel OrderOneLabel;

	public UILabel OrderOneCntLabel;

	public GameObject OrderTwoContainer;

	public UILabel OrderTwoLabel;

	public UILabel OrderTwoCntLabel;

	public GameObject OrderThreeContainer;

	public UILabel OrderThreeLabel;

	public UILabel OrderThreeCntLabel;

	public GameObject OrderFourContainer;

	public UILabel OrderFourLabel;

	public UILabel OrderFourCntLabel;

	public UIGrid CompareDataGrid;

	public GameObject OrderOneCompareContainer;

	public UILabel OrderOneCompareLabel;

	public UILabel LeftOrderOneCompareCntLabel;

	public UILabel RightOrderOneCompareCntLabel;

	public GameObject OrderTwoCompareContainer;

	public UILabel OrderTwoCompareLabel;

	public UILabel LeftOrderTwoCompareCntLabel;

	public UILabel RightOrderTwoCompareCntLabel;

	public GameObject OrderThreeCompareContainer;

	public UILabel OrderThreeCompareLabel;

	public UILabel LeftOrderThreeCompareCntLabel;

	public UILabel RightOrderThreeCompareCntLabel;

	public UINetworkTexture Bg_Pro;

	public UINetworkTexture Bg_MVP;

	public UITexture AvatarRTTexture;

	public UITexture RightAvatarRTTexture;

	public GameObject AvatarTextureContainer;

	public GameObject LeftAvatarTextureContainer;

	public GameObject RightAvatarTextureContainer;

	public UITexture LeftAvatarRTTexture;

	public Animation MainAnim;

	public Transform MainTrans;

	public UIColor CompareIdColor;

	public UIColor MvpIdColor;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
