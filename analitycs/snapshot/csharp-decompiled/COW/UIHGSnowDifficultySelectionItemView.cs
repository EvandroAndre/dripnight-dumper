using GCommon;
using UnityEngine;

namespace COW;

public class UIHGSnowDifficultySelectionItemView : UIBaseView
{
	public UINetworkTexture CdnBg;

	public UISprite SpriteAward;

	public UILabel RecordTitle;

	public UILabel RecordValue;

	public UIButton BtnRecord;

	public UILabel LabelDifficultyName;

	public UIButton BtnSelectDifficulty;

	public GameObject Record;

	public UIButton BtnAward;

	public GameObject Selected;

	public Animation ClickAnim;

	public Animation MainAnim;

	public AnimatedAlpha MainAlpha;

	public Animation UnlockAnim;

	public GameObject LockEffect;

	public GameObject UnlockEffect;

	public GameObject LabelNodata;

	public UIWidget GuideWidget;

	public Transform DownloaderConatainer;

	public GameObject AwardEffect;

	public UINetworkTexture LockCdnBg;

	public TweenRotation AwardAnim;

	public UISprite Bg;

	public UISprite Line;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
