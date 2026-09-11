using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendItemView : UIBaseView
{
	public BoxCollider UIFriendItem;

	public GameObject FriendInfoContainer;

	public UINetworkTexture FriendInfoIcon;

	public UILabel LevelNumLabel;

	public UILabel FriendStatLabel;

	public UILabel NickNameLabel;

	public GameObject GameFriendProfileContainer;

	public UIButton ItemBtn;

	public GameObject AccountStatePivot_Right;

	public UILabel AccountState_InGame_Right;

	public UILabel AccountState_Offline_Right;

	public UILabel AccountState_Online_Right;

	public UIButton AddBtn;

	public UIButton SendGiftBtn;

	public UISprite GiftIcon;

	public UIButton ChatBtn;

	public GameObject AccountStatePivot;

	public UILabel AccountState_InGame;

	public UILabel AccountState_InGame_Time;

	public UILabel AccountState_Offline;

	public UILabel AccountState_Online;

	public GameObject Add_Tag;

	public GameObject TagPos_0;

	public UISprite Tag_BG_0;

	public UILabel Tag_Label_0;

	public GameObject TagPos_1;

	public UISprite Tag_BG_1;

	public UILabel Tag_Label_1;

	public UISprite ItemBg;

	public GameObject PlatformInfoContainer;

	public GameObject PlatformIcon;

	public UILabel PlatformNickNameLabel;

	public GameObject RecommendRoot;

	public UISprite Gender;

	public UISprite LanguageIcon;

	public UILabel ModePreferLabel;

	public UILabel TimeActiveLabel;

	public Animation main;

	public GameObject CompatibleVersionContainer;

	public GameObject NewVersion;

	public GameObject OldVersion;

	public UIButton NewVersionBtn;

	public UILabel NewVersionLabel;

	public UILabel OldVersionLabel;

	public UIButton FriendIntimacyBtn;

	public UILabel IntimacyValueLabel;

	public GameObject TagPos_2;

	public UISprite Tag_BG_2;

	public UILabel Tag_Label_2;

	public UITable TabTable;

	public UIButton DetailsBtn;

	public Transform Arrow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
