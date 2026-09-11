using GCommon;
using UnityEngine;

namespace COW;

public class UIAchievementMainItemView : UIBaseView
{
	public UILabel LabelName;

	public GameObject Completed;

	public UILabel LabelDate;

	public UIButton BtnAchievementDetail;

	public UINetworkTexture CdnIcon;

	public UISprite AwardTipsIcon;

	public Animation MainAnim;

	public GameObject NewGainEffect;

	public Transform GlowEffect;

	public GameObject EggContainer;

	public GameObject EggAchievementContainer;

	public UIButton EggAchievementBtn;

	public GameObject NormalContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
