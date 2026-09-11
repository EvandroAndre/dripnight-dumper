using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisNotificationView : UIBaseView
{
	public GameObject SpecialMessageContent;

	public Animation SpecialMessageAnim;

	public UILabel SpecialMessageTxt;

	public GameObject SpecialIcon;

	public GameObject SettleWinMessageContent;

	public Animation SettleWinMessageAnim;

	public UILabel SettleWinMessageTxt;

	public UILabel SettleWinDetailTxt;

	public GameObject SettleLoseMessageContent;

	public Animation SettleLoseMessageAnim;

	public UILabel SettleLoseMessageTxt;

	public UILabel SettleLoseDetailTxt;

	public GameObject NormalMessageContent;

	public UILabel NormalMessageTxt;

	public GameObject RewardMessageContent;

	public UIHudMetropolisStarAnimParam StarAnimParam;

	public UILabel RewardNormalMessageTxt;

	public UIGrid RewardItemGrid;

	public GameObject RewardStarContent;

	public GameObject RewardItemContent;

	public GameObject NormalUIAnchorContain;

	public GameObject RewardSpecialContent;

	public UILabel RewardSpecialMessageTxt;

	public GameObject RewardNormalContent;

	public UILabel RewardSpecialTitieTxt;

	public Animation RewardMessageAnim;

	public Animation NormalMessageAnim;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
