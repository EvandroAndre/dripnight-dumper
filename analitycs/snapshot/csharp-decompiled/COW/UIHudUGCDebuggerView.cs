using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCDebuggerView : UIBaseView
{
	public UIButton BtnDrop;

	public UIButton OpenConsoleBtn;

	public UIButton PauseGameBtn;

	public UIButton OpenGMCmdBtn;

	public UILabel LabelGOD;

	public UILabel LabelHeal;

	public UIButton GodBtn;

	public UIButton HealBuffBtn;

	public UIButton KillSelfBtn;

	public UIButton TeleportBornBtn;

	public UISprite bg;

	public UIWidget DebuggerBtns;

	public UIGrid GMBtns;

	public Transform Content;

	public GameObject TopRight;

	public UISprite GodBtnOutline;

	public GameObject GMLabels;

	public BoxCollider DragCollider;

	public UIDragDropScreenBoundItem DragItem;

	public GameObject MidSplit;

	public UIButton EndCurrentPhaseBtn;

	public UIEventTrigger SpaceBtn;

	public UISprite HealBuffSelected;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
