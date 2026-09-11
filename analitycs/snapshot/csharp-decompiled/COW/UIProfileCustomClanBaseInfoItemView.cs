using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomClanBaseInfoItemView : UIBaseView
{
	public GameObject Selected;

	public UIButton RemoveBtn;

	public UIButton Button;

	public ProfileCustomDragDropItem DragItem;

	public GameObject Icon;

	public UILabel ClanNameLabel;

	public UILabel ClanLevelLabel;

	public GameObject ClanLogo;

	public UISprite ClanBadge;

	public UISprite ClanFrame_L;

	public UISprite ClanFrame_R;

	public UINetworkTexture ClanBadgeCDN;

	public GameObject NormalBgContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
