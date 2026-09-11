using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyGroupV2InGameTeamInfoItemView : UIBaseView
{
	public UINetworkTexture HeadIcon;

	public UIEffectSprite HeadSprite;

	public UISprite FakeSprite;

	public GameObject Occupied;

	public GameObject Vacant;

	public Transform RankContainer;

	public GameObject Captain;

	public GameObject NotReady;

	public GameObject Ready;

	public UIButton SelectBtn;

	public Transform PrimeShareContainer;

	public UITable RightTable;

	public UILabel PrimeBubbleLabel;

	public GameObject PrimeBubbleContainer;

	public GameObject OfferSetShare;

	public UICountDownLabel LabelDisableOfferCountdown;

	public GameObject ApplySetShare;

	public UICountDownLabel LabelDisableApplyCountdown;

	public UIButton OfferSetShareBtn;

	public UIButton ApplySetShareBtn;

	public UILabel NameLabelWithPrivilege;

	public Transform PrivilegeContainer;

	public Transform PrivilegeIconContainer;

	public UILabel NameLabel;

	public GameObject RankLimitContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
