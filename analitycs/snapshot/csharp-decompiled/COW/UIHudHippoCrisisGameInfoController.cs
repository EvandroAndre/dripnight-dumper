using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHippoCrisisGameInfoController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<CAOKNOOGCDE> _003C_003E9__10_0;

		internal int _003COnUIInit_003Eb__10_0(CAOKNOOGCDE a, CAOKNOOGCDE b)
		{
			return 0;
		}
	}

	private UIHudHippoCrisisGameInfoView m_View;

	private List<CAOKNOOGCDE> m_IncomeLst;

	private Dictionary<uint, CAOKNOOGCDE> m_IncomeDic;

	private UIHudHippoCrisisIncomeDetailPopOverController m_PopOverController;

	private uint m_CurLevel;

	private uint m_CurScore;

	private List<uint> m_HasShowLevels;

	private UIModelHippoCrisis m_ModelHC;

	private List<Transform> m_LevelVfxs;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	public void ShowScore(bool b)
	{
	}

	private void OpenDetailPop()
	{
	}

	private void OnLocalPlayerIncomeChange(object[] data)
	{
	}

	private void ShowNoti()
	{
	}

	private void UpdateGradeUI()
	{
	}

	private void PlayAnim(uint level)
	{
	}

	private uint GetScoreLevel(uint score)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
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
