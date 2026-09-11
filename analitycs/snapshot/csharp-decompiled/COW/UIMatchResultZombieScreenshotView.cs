using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchResultZombieScreenshotView : UIBaseView
{
	public ShareCamera ShareCameraObject;

	public GameObject ShareUI;

	public UINetworkTexture HeadshotRemote;

	public GameObject HeadshotDefault;

	public UIEffectSprite HeadshotLocal;

	public UILabel PlayerID;

	public UILabel PlayerNickname;

	public UILabel EndgameDescription;

	public UILabel Defeater;

	public UILabel PlayerRank;

	public UILabel TotalPlayersCount;

	public UISprite PlayerRankTop;

	public UISprite PlayerCharacter;

	public UITexture BG_Shared;

	public UITexture GameTexture;

	public UIGrid Teammates;

	public UILabel MatchMode;

	public UILabel GameMode;

	public UILabel Map;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
