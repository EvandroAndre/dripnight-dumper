using GCommon;
using UnityEngine;

namespace COW;

public class UIClanListItemView : UIBaseView
{
	public UISprite ClanBadge;

	public UILabel LV;

	public UILabel GuildName;

	public UILabel Members;

	public GameObject AuditApproveLabel;

	public GameObject AutoWithCond;

	public UILabel AutoLabelWithCond;

	public UITable AutoCondContent;

	public UILabel AutoLevel;

	public UISprite Rank;

	public UISprite CSRank;

	public GameObject AutoWithoutCond;

	public GameObject AuditAutoLabel;

	public UITable MembersContainer;

	public UILabel Friends;

	public UISprite LocalGuild;

	public UIButton SelectButton;

	public Transform SelectedBG;

	public Transform UnSelectedBG;

	public UISprite ClanFrame;

	public UINetworkTexture ClanBadgeCDN;

	public GameObject AuditWithoutCond;

	public UILabel AuditLabelWithCond;

	public GameObject ClanCertification;

	public UITable GuildNameContainer;

	public UILabel GuildMainTag;

	public GameObject GuildMainTagContainer;

	public UISprite TagBg;

	public UITable GuildNmeMainTanContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
