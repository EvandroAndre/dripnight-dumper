using GCommon;
using UnityEngine;

namespace COW;

public class UIHGSnowDifficultySelectionBigItemView : UIBaseView
{
	public UINetworkTexture CdnBg;

	public UISprite SpriteAward;

	public UILabel RecordTitle;

	public UILabel RecordValue;

	public UIButton BtnRecord;

	public UILabel SpecialDifficultyName;

	public UIButton BtnSelectDifficulty;

	public GameObject Record;

	public UIButton BtnBuff;

	public GameObject BuffIcon;

	public UIButton BtnAward;

	public GameObject Selected;

	public Animation ClickAnim;

	public Animation MainAnim;

	public AnimatedAlpha MainAlpha;

	public Animation UnlockAnim;

	public GameObject LabelNodata;

	public UIWidget GuideWidget;

	public Transform DownloaderConatainer;

	public GameObject AwardEffect;

	public UINetworkTexture LockCdnBg;

	public TweenRotation AwardAnim;

	public GameObject NormalTitlelContainer;

	public GameObject SpecialTitlelContainer;

	public UILabel NormalDifficultyName;

	public GameObject EmptyContainer;

	public GameObject Award;

	public GameObject LabelDifficultyName;

	public GameObject UIFX_Glow;

	public GameObject Unlock;

	public Transform BuffDetailPos;

	public GameObject Time;

	public GameObject CountDownContainer;

	public GameObject LableContainer;

	public UILabel TimeLabel2;

	public UILabel TimeLabel1;

	public UILabel CountDownTipsLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
