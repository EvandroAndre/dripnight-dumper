using GCommon;
using UnityEngine;

namespace COW;

public class UIClanProfileItemView : UIBaseView
{
	public UILabel ClanName;

	public UISprite ClanBadge;

	public UILabel IdLabel;

	public UISprite ClanFrame_L;

	public UISprite ClanFrame_R;

	public UINetworkTexture ClanBadgeCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
