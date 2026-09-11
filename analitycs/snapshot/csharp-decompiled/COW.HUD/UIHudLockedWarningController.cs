using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

public class UIHudLockedWarningController : UIBaseController
{
	private UIHudLockedWarningView m_View;

	private List<LevelMissileBase> m_BindMissiles;

	private const float SountRange = 30f;

	private Dictionary<LevelMissileBase, GameObject> m_WarningSounds;

	private FOCGJHJOBFE m_LastPawn;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	internal void BindMissile(LevelMissileBase m)
	{
	}

	internal void UnBindMissile(LevelMissileBase m)
	{
	}

	private void HideAndClearStates()
	{
	}

	private void Update()
	{
	}

	private void StartSound(Entity target, LevelMissileBase m)
	{
	}

	private void StopSound(LevelMissileBase m)
	{
	}

	private void StopAllSounds()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
