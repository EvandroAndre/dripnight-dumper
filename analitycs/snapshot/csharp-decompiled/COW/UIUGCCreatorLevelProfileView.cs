using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCCreatorLevelProfileView : UIBaseView
{
	public UITable IconTable;

	public UITable Table;

	public UILabel unlockTime;

	public UILabel RightExp;

	public UILabel RightLv;

	public UILabel FollowerNum;

	public UILabel LeftExp;

	public UILabel LeftLv;

	public UIGrid AbilityGrid;

	public UIGrid IconGrid;

	public UIGrid PlatformGrid;

	public UIProgressBar ExpBar;

	public UIButton HelpBtn;

	public Transform RewardNode;

	public GameObject lockIcon;

	public UIButton BtnSetting;

	public UIButton BtnName;

	public UIToggle NameToggle;

	public GameObject Node;

	public UISprite Back;

	public GameObject Lock;

	public GameObject Setting;

	public UINetworkTexture Texture;

	public UIButton BtnClose;

	public UIScrollView AbilityScrollView;

	public UIButton ExpHelpBtn;

	public Transform ArchitectIcon;

	public Animation PrivilegeAnim;

	public UITable LockTable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
