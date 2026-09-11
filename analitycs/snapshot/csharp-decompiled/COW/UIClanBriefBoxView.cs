using GCommon;
using UnityEngine;

namespace COW;

public class UIClanBriefBoxView : UIBaseView
{
	public UIWidget Container;

	public GameObject ProfileContainer;

	public UILabel IdLabel;

	public GameObject TitleContainer;

	public UISprite ClanBadge;

	public UILabel ClanName;

	public UILabel ClanLevel;

	public UILabel ClanActive;

	public UILabel ClanLocation;

	public MinWidgetTableItem MinWidget;

	public LayoutTable Other;

	public GameObject LeaderContainer;

	public GameObject LeaderProfilePviot;

	public GameObject FriendsContainer;

	public UIScrollView FrinedsScroll;

	public UITable FriendsList;

	public GameObject SologonContainer;

	public UILabel SologonLabel;

	public GameObject TagContainer;

	public UITable TagList;

	public GameObject JoinBtnContainer;

	public UIButton JoinBtn;

	public GameObject AutoJoinLabel;

	public GameObject ApprovalJoinLabel;

	public UISprite BGBorder;

	public UISprite TitleBG;

	public GameObject UIClanBriefBox;

	public UISprite ClanFrame_L;

	public GameObject ApplyContainer;

	public UILabel ApplyLevel;

	public UISprite BRIcon;

	public UISprite CSIcon;

	public UITable ApplayLimit;

	public UISprite ClanFrame_R;

	public UINetworkTexture ClanBadgeCDN;

	public Transform TitlePviot;

	public GameObject AutoJoinLabelGray;

	public GameObject ApprovalJoinLabelGray;

	public GameObject JoinEnableBG;

	public GameObject JoinDisableBG;

	public GameObject ClanCertification;

	public UILabel ClanMember;

	public UIButton NoJoinBtn;

	public UILabel NoJoinLabel;

	public GameObject BriefBoxPosLeft;

	public UIButton GotoClanBtn;

	public GameObject BGBorderShort;

	public Transform BGShortBtnPos;

	public GameObject BriefBoxPosRight;

	public UILabel ApplayType;

	public UITable Name;

	public UIButton ClanWarHistoryBtn;

	public GameObject NoClanWarHistoryIcon;

	public GameObject ClanWarHistoryIcon;

	public UILabel GloryNumLabel;

	public GameObject MiddlePos;

	public UIButton ClanReportBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
