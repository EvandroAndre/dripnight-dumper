using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyNotificationGuildInviteView : UIBaseView
{
	public UISprite GuilBGSprite;

	public UILabel GuildLevel;

	public UILabel GuildName;

	public UILabel Inviter;

	public UIButton ConfirmBtn;

	public UINetworkTexture GuildIconCdn;

	public UISprite GuildIconSprite;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
