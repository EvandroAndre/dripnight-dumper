using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLobbySocialAreaNameView : UIBaseView
{
	public UITable NameTable;

	public GameObject RelationshipContainer;

	public UISprite RelationshipIcon;

	public GameObject WinStreakContainer;

	public GameObject PrivilegeIconContainer;

	public UILabel NameLabel;

	public GameObject VoiceContainer;

	public GameObject RankContainer;

	public UILabel WinStreak;

	public GameObject TitleContainer;

	public Transform QueueStateContainer;

	public TweenAlpha TweenVoiceIcon;

	public Transform DownloadContainer;

	public UIButton NameBtn;

	public UIWidget GuideWidget;

	public Transform GuideContainer;

	public Transform TitleSelectionContainer;

	public Transform CarryHit;

	public UIPanel NamePanel;

	public Transform LeaderboardTitleContainer;

	public Transform CommonTitleContainer;

	public Transform SocialAreaTitleContainer;

	public Transform DownloadContainerContainer;

	public GameObject PrivilegeContainer;

	public UIButton TitleBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
