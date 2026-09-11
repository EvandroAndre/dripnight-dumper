using GCommon;
using UnityEngine;

namespace COW;

public class UIElitePassWaitingRoomRankingView : UIBaseView
{
	public UIGrid Grid;

	public ElitePassWaittingRoomRanking Top1Player;

	public ElitePassWaittingRoomRanking Top2Player;

	public ElitePassWaittingRoomRanking Top3Player;

	public ElitePassWaittingRoomRanking MePlayer;

	public UITexture AvatarTexture;

	public GameObject EpTexture;

	public GameObject BpGameObject;

	public UINetworkTexture BpNetWorkTexture;

	public UILabel Title;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
