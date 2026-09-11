using GCommon;
using UnityEngine;

namespace COW;

public class UICommonRewardWndView : UIBaseView
{
	public GameObject Mask;

	public UIButton SkipMask;

	public GameObject RewardContainer;

	public UIWidget RewardContainerWidget;

	public Transform ExtraItem;

	public UIGrid RewardGrid;

	public GameObject RewardGridLeftPos;

	public GameObject RewardGridMiddlePos;

	public GameObject Label;

	public UILabel FreeRewardLabel;

	public UILabel OptionalLabel;

	public UILabel OptionalLabelStatic;

	public GameObject BG;

	public Transform Others;

	public GameObject OthersContainer;

	public Transform CollectionValueIncreaseRoot;

	public UIScrollView NoLimitRewardScrollView;

	public UIEasyList NoLimitEasyList;

	public UIEasyListIntervalShowHelper EasyListIntervalShowHelper;

	public UIButton SkipPermanentMergeMask;

	public Transform QuickMessageView;

	public GameObject Extraicon;

	public UIScrollView HippoCrisisPurchaseItemScrollView;

	public UIEasyList HippoCrisisPurchaseItemEasyList;

	public Transform GachaLuckyContainer;

	public UIButton ShareBtn;

	public Transform EmojiRainContainer;

	public GameObject GemRefund;

	public UIButton GemRefundTipsBtn;

	public UIScrollView BeforeOpenBundleRewardScrollView;

	public UIEasyList BeforeOpenBundleEasyList;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
