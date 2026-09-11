using GCommon;
using UnityEngine;

namespace COW;

public class UIGachaLimitChestContentView : UIBaseView
{
	public Animator LeftPageAni;

	public UITable Table;

	public GameObject CountDownContent;

	public UICountDownIcon CountDownIcon;

	public UICountDownLabel GachaCountDownLabel;

	public GameObject BGMask;

	public GameObject UnselectedNode;

	public UILabel DescLabel;

	public UIToggleButton Toggle1;

	public UIToggleButton Toggle2;

	public GameObject Reward1;

	public GameObject Reward2;

	public GameObject Reward3;

	public GameObject Reward4;

	public GameObject Reward5;

	public GameObject Reward6;

	public GameObject Selected;

	public UIButton NextBtn;

	public UIButton ConfirmBtn;

	public GameObject LimitTurnTableName;

	public UINetworkTexture LimitTitleCDN;

	public GameObject NormalNode;

	public GameObject EffectNode;

	public GameObject DisplayRewardNodes;

	public GameObject Node1;

	public GameObject Node2;

	public GameObject Node3;

	public GameObject Node4;

	public GameObject Node5;

	public GameObject Node6;

	public GameObject SelectedNode;

	public GameObject BuyBtnNode;

	public GameObject AllGetedLabel;

	public UISlider Loading;

	public UILabel LoadingLabel;

	public UICheckboxButton DisplayRewardToggle;

	public GameObject InterfaceMaskLabel;

	public GameObject AniReplayBtnNode;

	public UIWidget PreviewBorderBeforeChoose;

	public UIWidget PreviewBorderAfterChoose;

	public Transform StartEffectContainer;

	public Transform BoxEffectContainer;

	public Transform PrimeCountDown;

	public Transform NoPrimeTipsTr;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
