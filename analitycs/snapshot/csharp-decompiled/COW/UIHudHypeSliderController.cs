using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudHypeSliderController : UIBaseController
{
	private UIHudHypeProcessBarView m_View;

	private const float m_HypeResetValue = 0f;

	private ushort m_CurrentHypeValue;

	private ushort m_LastHypeValue;

	private ushort m_MaxHypeValue;

	protected ushort m_CurrentHypeLevel;

	private ushort m_MaxHypeLevel;

	private float m_HypeChangeProcess;

	private const int m_SliderChangeSpeed = 3;

	private Dictionary<ushort, Transform> m_LevelUpBlockDic;

	private Dictionary<ushort, Transform> m_LevelBgDic;

	private int TOTAL_BAR_WIDTH;

	private const float m_HypeValueChangedPassedTime = 2f;

	private bool m_HypeValueHadChanged;

	private float m_Timer;

	private bool m_IsFootball;

	public bool HadHypeValueChanged
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected void Update()
	{
	}

	private void ShowSliderValueChange(float progress)
	{
	}

	private void OnFootBallRadiusChange(float radius)
	{
	}

	private void OnFootBallStatusChange(object[] data)
	{
	}

	private void OnHypeValueChange(object[] data)
	{
	}

	protected virtual void OnHypeLevelChange(object[] data)
	{
	}

	private void OnMaxHypeValueChange(object[] data)
	{
	}

	private void OnMaxHypeLevelChange(object[] data)
	{
	}

	private void UpdateBarItem()
	{
	}

	private void RefreshHypeValueState()
	{
	}

	private void ResetLevelBlockStateAndSliderBgPos(ushort newLevel)
	{
	}

	protected virtual void ShowMaxHypeLevelEffect(bool _needshow)
	{
	}

	private void ShowHypeLevelUpAnim()
	{
	}

	private void ShowHypeChangeEffect(bool isIncreasing)
	{
	}

	private void OnSwitchObserver(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
