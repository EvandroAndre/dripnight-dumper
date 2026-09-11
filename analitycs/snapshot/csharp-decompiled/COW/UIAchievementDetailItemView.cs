using GCommon;
using UnityEngine;

namespace COW;

public class UIAchievementDetailItemView : UIBaseView
{
	public GameObject Completed;

	public UILabel LabelDate;

	public UILabel LabelPoint;

	public GameObject Point;

	public UILabel LabelDesc;

	public TweenAlpha Arrow;

	public UINetworkTexture CdnIcon;

	public TweenAlpha CdnIconTweenAlpha;

	public UIGrid AwardGrid;

	public UIButton BtnAward;

	public Transform GlowEffect;

	public GameObject Content;

	public Animation MainAnim;

	public GameObject NewGainEffect;

	public UILabel LabelDescSpecial;

	public UIButton BtnDesc;

	public GameObject LabelNewPlayerExploreContainer;

	public UILabel LabelNewPlayerExplore;

	public GameObject AwardTrail;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
