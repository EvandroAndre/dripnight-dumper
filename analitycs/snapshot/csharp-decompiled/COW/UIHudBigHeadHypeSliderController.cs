using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudBigHeadHypeSliderController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public GameObject go;

		internal void _003COnSyncBuffState_003Eb__0()
		{
		}
	}

	private UIHudBigHeadHypeProcessBarView m_View;

	private bool m_TutShowed;

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

	private uint m_BuffLevelDelayCall;

	private int m_CurrentBuffID;

	private UIClickMask m_ClickMask;

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

	protected void OnHypeLevelChange(object[] data)
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

	private void ShowHypeLevelUpAnim()
	{
	}

	private void ShowHypeChangeEffect(bool isIncreasing)
	{
	}

	private void OnPlayerRevive(object[] data)
	{
	}

	private void OnSwitchObserver(object[] data)
	{
	}

	private void OnBuffIconPressed(GameObject go)
	{
	}

	private void OnSyncBuffState(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
