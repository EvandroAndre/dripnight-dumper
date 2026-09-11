using GCommon;
using UnityEngine;

namespace COW;

public class UIRoomListSettingPreviewView : UIBaseView
{
	public UITable DetailInfoTable;

	public UIPanel PresetDetailScrollViewPanel;

	public UIScrollView PresetDetailScrollView;

	public UIButton PlayJionBtn;

	public UIButton OBJoinBtn;

	public UIButton CloseMask;

	public UILabel GameMode;

	public UILabel GroupMode;

	public GameObject CanJoinPlay;

	public GameObject LevelLimit;

	public GameObject PlayerFull;

	public GameObject CanJoinOB;

	public GameObject OBFull;

	public GameObject JoinPlayUnable;

	public GameObject JoinOBUnable;

	public GameObject Ingame;

	public UIPanel UIRoomListSettingPreview;

	public UILabel LevelLimitLabel;

	public UISprite PlayJoinSprite;

	public UISprite OBJoinSprite;

	public UILabel JoinOBUnableLabel;

	public GameObject TournamentLimit;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
