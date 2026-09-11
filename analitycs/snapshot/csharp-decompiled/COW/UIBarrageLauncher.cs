using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBarrageLauncher : UIBaseController
{
	public Transform StartPos;

	public Transform EndPos;

	public float FlyingTime;

	public bool Paused;

	public float FirstLauncherDelayMax;

	public float FirstLauncherDelayMin;

	public Type ControllerTypeOverride;

	public float YRandomRange;

	private bool m_AxisReady;

	private bool m_VelocityReady;

	private Dictionary<uint, UIBarrageItemPool> m_UIBarrageItemPoolDic;

	public bool ConfigReady => false;

	public void InitControllerTypes(HashSet<int> types, bool isPaused = false)
	{
	}

	public bool LaunchNew(BarrageData data)
	{
		return false;
	}

	public void InitConfig()
	{
	}

	public void ForceHideAllBarrage()
	{
	}

	private void Update()
	{
	}

	private bool GetAxisDirection()
	{
		return false;
	}

	private bool IsInBarrageArea(Vector3 localPos)
	{
		return false;
	}

	private bool CalculVelocity()
	{
		return false;
	}

	private UIBarrageItemBaseController OpenBarrageItem(BarrageData data)
	{
		return null;
	}

	private void MoveBarrageItem(UIBarrageItemBaseController item)
	{
	}

	private void RefreshBarrages()
	{
	}
}
