using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomBattleShareWinView : UIBaseView
{
	public UILabel TitleLabel;

	public UINetworkTexture ResultIcon;

	public UILabel FriendLabel;

	public UIButton ChangeFriendBtn;

	public GameObject ChangeFriendContainer;

	public UILabel ChangeLabel;

	public UISprite ChangeBG;

	public UITable FriendTable;

	public UITable LeftSmallTable;

	public UITable LeftBigTable;

	public UITable RightSmallTable;

	public UITable RightBigTable;

	public UIRoomBattleShareWinSmallItemView SmallPlayerTemplate;

	public UIRoomBattleShareWinBigItemView BigPlayerTempalte;

	public UIRoomBattleShareWinFriendItemView FriendPlayerTemplate;

	public UIGrid LeftSmallGrid;

	public UIGrid RightSmallGrid;

	public UIRoomBattleShareWinBigItemView BigPlayerTempalte_R;

	public GameObject VSL_2;

	public GameObject VSL_3;

	public GameObject VSL_4;

	public GameObject VSL_5;

	public GameObject VSR_5;

	public GameObject VSR_4;

	public GameObject VSR_3;

	public GameObject VSR_2;

	public UIPanel ResultIconMask;

	public UILabel TitleName_Label;

	public UILabel FriendName_Label;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
