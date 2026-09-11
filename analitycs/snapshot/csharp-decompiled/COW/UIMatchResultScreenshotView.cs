using GCommon;
using UnityEngine;

namespace COW;

public class UIMatchResultScreenshotView : UIBaseView
{
	public ShareCamera ShareCameraObject;

	public GameObject ShareUI;

	public UINetworkTexture HeadshotRemote;

	public GameObject HeadshotDefault;

	public UIEffectSprite HeadshotLocal;

	public UISprite callsign;

	public UILabel PlayerID;

	public UILabel PlayerNickname;

	public UILabel EndgameDescription;

	public UILabel Defeater;

	public UILabel WeaponDefeatedWith;

	public UILabel GameMode;

	public UILabel Map;

	public UILabel PlayerRank;

	public UILabel TotalPlayersCount;

	public UISprite SeasonRankIcon;

	public UILabel SeasonRank;

	public GameObject rankcolor;

	public GameObject bronze;

	public GameObject silver;

	public GameObject gold;

	public GameObject platinum;

	public GameObject diamon;

	public GameObject king;

	public GameObject peek;

	public UILabel playerKill;

	public UILabel playerDamage;

	public UILabel playerSurviveTime;

	public UITable Team;

	public GameObject Teammate1;

	public UILabel teammate1Kill;

	public UILabel teammate1Name;

	public GameObject Teammate2;

	public UILabel teammate2Kill;

	public UILabel teammate2Name;

	public GameObject Teammate3;

	public UILabel teammate3Kill;

	public UILabel teammate3Name;

	public UITexture PlayerAvatar;

	public UITexture BG_Shared;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
