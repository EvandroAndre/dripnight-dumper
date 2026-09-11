using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMatchResultDetailView : UIBaseView
{
	public UITable MatchResultDetailTable;

	public UIWidget GoldContainer;

	public GameObject ExpContainer;

	public GameObject PetExpContainer;

	public GameObject ClanActivityPointContainer;

	public GameObject PenaltyDesclabelContainer;

	public UILabel GoldNum;

	public UILabel ExpNum;

	public UILabel PetExpNum;

	public UILabel ClanActivityPointNum;

	public UILabel TitleBuffLabel;

	public GameObject TitleBuffLabelContainer;

	public UISprite bg;

	public GameObject MatchObserverReward;

	public UILabel RewardGoldNum;

	public UITable GoldTable;

	public GameObject MatchGainGold;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
