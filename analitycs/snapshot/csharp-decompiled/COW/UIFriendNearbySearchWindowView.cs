using GCommon;
using UnityEngine;

namespace COW;

public class UIFriendNearbySearchWindowView : UIBaseView
{
	public UIButton CloseBtn;

	public UIButton SettingBtn;

	public UIButton QuestionBtn;

	public UILabel SearchLabel;

	public UIButton BtnNearbySearch;

	public UIButton BtnRefresh;

	public UIButton BtnAddAll;

	public UISprite head;

	public GameObject NearbyFriendList;

	public GameObject NearbyFriendContainer1;

	public GameObject NearbyFriendContainer2;

	public GameObject NearbyFriendContainer3;

	public GameObject NearbyFriendContainer4;

	public GameObject NearbyFriendContainer5;

	public UINetworkTexture HeadIcon;

	public UIEffectSprite HeadSprite;

	public GameObject FakeSprite;

	public GameObject UIFX_UIFriendNearbySearchWindow_ContentPanel;

	public Animation UIFX_UIFriendNearbySearchWindow_ContentPanelAnimation;

	public GameObject saomiao;

	public UINetworkTexture BG;

	public GameObject AddIcon;

	public GameObject AllReadyAddIcon;

	public UIPanel UIFriendNearbySearchWindow;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
