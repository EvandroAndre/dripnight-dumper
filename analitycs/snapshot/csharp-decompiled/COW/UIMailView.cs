using GCommon;
using UnityEngine;

namespace COW;

public class UIMailView : UIBaseView
{
	public UILabel CountLabel;

	public UIScrollView MailScrollView;

	public UIEasyList MailList;

	public GameObject NoMail;

	public Transform RightContainer;

	public UIScrollView ContentScrollView;

	public UIPanel PanelMailContent;

	public UILabel MailContent;

	public GameObject ReportContentRoot;

	public UIScrollView ReportContentScrollView;

	public UILabel ReportContent1;

	public UITable ReportContentReasonTable;

	public UILabel ReportContent3;

	public UILabel ReportSignature;

	public UILabel ReportTime;

	public UIWidget RewardContainer;

	public UIScrollView RewardScrollView;

	public UIGrid RewardGrid;

	public UILabel MailTitle;

	public UIButton AcceptBtn;

	public UIButton RejectBtn;

	public UIButton ReceiveAllBtn;

	public UIButton DeleteAllBtn;

	public UIButton ReceiveBtn;

	public UIButton DeleteBtn;

	public UIScrollView ReportMailScrollView;

	public UIEasyList ReportMailList;

	public UILabel ReportContent2;

	public GameObject ReportDetails;

	public UILabel GoToCreditLabel;

	public UIButton GoToCreditButton;

	public UILabel LabelReceiveAll;

	public UILabel LabelDeleteAll;

	public UIButton GoPosBtn;

	public UILabel GoPosBtnLabel;

	public UIButton GotoHistoryDetailBtn;

	public GameObject ReportGoPosContainer;

	public UIButton ReportGoPosBtn;

	public UILabel ReportGoPosLabel;

	public GameObject CDNContentRoot;

	public UINetworkTexture MailCDN;

	public UIButton MailCDNGoBtn;

	public Transform Top;

	public UINetworkTexture CDNContentWithReward;

	public UINetworkTexture CDNContentWithoutReward;

	public UITable ContentTable;

	public UIButton CDNContentWithRewardBtn;

	public UIButton CDNContentWithoutRewardBtn;

	public GameObject NormalMailContent;

	public GameObject GiftMailContent;

	public GameObject GiftMailPrimeContainer;

	public GameObject GiftMailNormalContainer;

	public Transform GiftMailCallsignContainer;

	public Transform GiftMailItemContainer;

	public UILabel GiftMailItemNameLabel;

	public UILabel GiftMailTextContentLabel_Prime;

	public UILabel GiftMailTextContentLabel;

	public UIButton GiftMailAddFriendBtn;

	public UIButton GiftMailAddFriendBtn_Prime;

	public UIButton GiftMailClaimBtn;

	public UINetworkTexture GiftMailPrimeBgCDN;

	public UINetworkTexture GiftMailNormalBgCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
