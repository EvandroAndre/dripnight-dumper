using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarChampionshipMiniLeaderboardItemView : UIBaseView
{
	public Transform TitleIconPos;

	public UILabel RankLabel;

	public UISprite ClanIcon;

	public UILabel ClanName;

	public UILabel Score;

	public GameObject GuildWarStartScoreNode;

	public UILabel StartScore;

	public UINetworkTexture ClanIconCdn;

	public UISprite ClanIconBg;

	public UIButton ItemBtn;

	public UIWidget ItemWidget;

	public GameObject Bg;

	public UISprite Bg1;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
