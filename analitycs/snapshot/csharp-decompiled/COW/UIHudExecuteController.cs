using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudExecuteController : UIBaseController
{
	private UIHudExecuteView m_View;

	private BHGGAEEHJCO m_TargetExecuteID;

	private BHGGAEEHJCO m_LastTargetExecuteID;

	private Vector3 diffPos;

	private Vector3 currentPos;

	private Transform tr;

	private bool m_IsExecuting;

	private bool m_IsRescuringVisile;

	private bool m_IsForceTutorialExecuteHighlightShown;

	private const string EXECUTE_ICON = "UI_Icon_Execution";

	private const string RESCURE_ICON = "help";

	private const TutorialEventEnum FORCE_TUTORIAL_EXECUTE_HIGHLIGHT = TutorialEventEnum.FORCE_TUTORIAL_BASICGUIDE_USEGRENADE2;

	private List<Player> m_TmpPendingPlayers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InternalCollectPendingEnemies(Player localPlayer, List<Player> pendingPlayers)
	{
	}

	private void CheckExecutionSkillStatus()
	{
	}

	private void Update()
	{
	}

	public void ModifyRescurePos(Vector3 pos)
	{
	}

	public void SetChangePos(Vector3 pos)
	{
	}

	private void OnCancelExecuteBtnClicked()
	{
	}

	private void OnRescureBtnClicked()
	{
	}

	private void OnHudSettingChanged(object[] param)
	{
	}

	private void OnLocalFireBtnDown(object[] param)
	{
	}

	private void OnCanRescureChanged(object[] data)
	{
	}

	private void TryShowForceTutorialExecuteHighlight()
	{
	}

	private void HideForceTutorialExecuteHighlight()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
