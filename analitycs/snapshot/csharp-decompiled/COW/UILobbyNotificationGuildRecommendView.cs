using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyNotificationGuildRecommendView : UIBaseView
{
	public UISprite GuildIconSprite;

	public UILabel GuildLevel;

	public UILabel GuildName;

	public UILabel Inviter;

	public UIButton ConfirmBtn;

	public UINetworkTexture GuildIconCdn;

	public Transform BriefBoxPos;

	public UISprite GuildBadge;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
