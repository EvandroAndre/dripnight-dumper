using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UICSGameScene : UIInGameScene, ILvlObjHPRecycler
{
	private Dictionary<ulong, UIBaseController> m_LvlObjHPControllers;

	private UIHudBuffIntroController m_BuffIntroCtrl;

	private UIHudCSRandomBuffEntryController randomBuffEntryController;

	public UIHudCSRandomBuffController randomBuffCtrl;

	protected UIHudCSChooseSkillConfirmController m_CSChooseSkillConfirmCtrl;

	protected override Type GetMatchResultType()
	{
		return null;
	}

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	public void OnShowBuffIntro(object[] data)
	{
	}

	private void ShowRandomBuff(object[] data)
	{
	}

	private void ShowCSRandomBuffEntry(bool show)
	{
	}

	private void ShowCSRandomBuff(bool show)
	{
	}

	protected override bool IsNeedShowGamePhaseCountdownUI()
	{
		return false;
	}

	protected override bool IsGameModeNeedSkySurfing()
	{
		return false;
	}

	protected override bool IsGameModeNeedCannon()
	{
		return false;
	}

	private void OnCSNewPhaseStarted(object[] param)
	{
	}

	public Vector3 GetGlobalMissionPos()
	{
		return default(Vector3);
	}

	private void OnLvlObjHPChanged(object[] data)
	{
	}

	public void RecycleLvlObjHPHud(uint id, OPICPDCLKAG lvlObjType)
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsNeedShowGamePhaseCountdownUI()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsGameModeNeedSkySurfing()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsGameModeNeedCannon()
	{
		return false;
	}
}
