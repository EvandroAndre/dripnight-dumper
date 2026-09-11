using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipAnimView : UIBaseView
{
	public Animator Animator;

	public UILabel SeasonID;

	public UILabel SeasonName;

	public UILabel SeasonTime;

	public GameObject SeasonInfo;

	public GameObject DefaultIcon;

	public UINetworkTexture CDNIcon;

	public GameObject ExclusiveAwardEffect;

	public UIButton ConfirmBtn;

	public UIButton GotoMailBtn;

	public GameObject ResultInfo;

	public UILabel RankScore;

	public UISprite CupIcon;

	public UILabel RankPos;

	public UIGrid RewardList;

	public GameObject Map;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
