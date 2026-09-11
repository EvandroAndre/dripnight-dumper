using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbyLWScoreboardView : UIBaseView
{
	public UINetworkTexture LeftHeadIcon;

	public UIEffectSprite LeftHeadSprite;

	public GameObject LeftHeadFakeSprite;

	public UILabel TxtPlayerNameLeft;

	public UILabel LeftStreakNumLabel;

	public UILabel TxtScoreLeft;

	public UILabel TxtScoreRight;

	public UINetworkTexture RightHeadIcon;

	public UIEffectSprite RightHeadSprite;

	public GameObject RightHeadFakeSprite;

	public UILabel RightStreakNumLabel;

	public GameObject RightStreakContainer;

	public GameObject LeftStreakContainer;

	public UILabel TxtPlayerNameRight;

	public GameObject EmptyState;

	public GameObject BattleState;

	public GameObject DefenderState;

	public UINetworkTexture DefenderHeadIcon;

	public UIEffectSprite DefenderHeadSprite;

	public GameObject DefenderHeadFakeSprite;

	public UILabel DefenderName;

	public GameObject DefenderStreakContainer;

	public UILabel DefenderStreakNumLabel;

	public GameObject LeftBooyah;

	public GameObject RightBooyah;

	public GameObject UIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
