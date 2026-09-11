using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIEasyListIntervalShowHelper : MonoBehaviour
{
	public float ShowRewardsInterval;

	public float ScrollInterval;

	private bool needScroll;

	private int m_PlayedRealIndex;

	private float m_LastPlayTime;

	private IntervalItem m_IntervalItemInfo;

	private bool m_Suspend;

	private bool m_ForceStopIntervalPlay;

	private HashSet<int> m_HasPlayedIndex;

	public Func<int, Action, bool> SuspendAction;

	public Action PlayIntervalDone;

	private bool m_NewShow;

	public bool UseNewItem;

	public bool ShowTween;

	private void Update()
	{
	}

	public void IntervalShowItem(IntervalItem intervalItem, IntervalItemStyle style = IntervalItemStyle.Default, bool newShow = false)
	{
	}

	public bool GetCurIndexPlayedState(int index)
	{
		return false;
	}

	public void MakePlayedIndexSet(int index)
	{
	}

	public void SetIntervalExtraInfo(int index)
	{
	}

	public void ForceStopIntervalPlay()
	{
	}

	private int _003CIntervalShowItem_003Eb__15_0()
	{
		return 0;
	}

	private int _003CIntervalShowItem_003Eb__15_1()
	{
		return 0;
	}

	private void _003CSetIntervalExtraInfo_003Eb__18_0()
	{
	}
}
