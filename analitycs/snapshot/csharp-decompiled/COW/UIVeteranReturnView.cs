using GCommon;
using UnityEngine;

namespace COW;

public class UIVeteranReturnView : UIBaseView
{
	public UINetworkTexture BGCDNTexture;

	public UITexture BGTexture;

	public UILabel Title;

	public UIGrid GridList;

	public UIButton GameBtn;

	public UILabel GameBtnLabel;

	public Animation RewardAnimation;

	public Animation VeteranAnimation;

	public GameObject SecondaryBtnContainer;

	public UIButton SecondaryGameBtn;

	public UILabel SecondaryGameBtnlabel;

	public GameObject ItemBG;

	public UILabel ProtectLabel2;

	public GameObject ProtectIcon;

	public GameObject CSSpecialMatchContainer;

	public GameObject CSSpecialMatchSelect;

	public GameObject CSSpecialMatchUnSelect;

	public UIButton CSSpecialMatchBtn;

	public GameObject ItemList;

	public GameObject TagTable;

	public GameObject ReturnRewardTitleContainer;

	public UITable ModeSubTable;

	public UILabel ReturnRewardLabel;

	public UITable RightBottomTable;

	public UIButton veteranReturnSubGOBtn;

	public UINetworkTexture ReturnRewardIconCdn;

	public GameObject ReturnRewardIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
