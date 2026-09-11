using GCommon;
using UnityEngine;

namespace COW;

public class UIAchievementDetailBigEventItemView : UIBaseView
{
	public GameObject Completed;

	public UILabel LabelDate;

	public UILabel Duration;

	public UINetworkTexture CdnIcon;

	public TweenAlpha CdnIconTweenAlpha;

	public GameObject Content;

	public Animation MainAnim;

	public GameObject BigAwardCompleted;

	public UIPanel BigRewardPos;

	public UILabel Label;

	public GameObject finished;

	public GameObject Reward;

	public GameObject Unfinished;

	public UINetworkTexture CdnLogo;

	public UIPanel Clamed;

	public UIPanel BigAwardCompletedIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
