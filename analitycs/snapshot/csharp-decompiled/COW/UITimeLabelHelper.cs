using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UITimeLabelHelper
{
	public UILabel Label;

	public float RedLabelSeconds;

	public int CountDownSoundSecond;

	public Color TextNormalColor;

	private bool Inited;

	private MutableString m_TextBuilder;

	private int m_LastSeconds;

	private EUITimeUpdateType m_TimeUpdateMethod;

	private float m_TimeBase;

	private float m_TimeTarget;

	private string m_ExtraString;

	private string m_Suffix;

	private string m_LocKey;

	private string m_ExtraLocKeyNeedParam;

	public EUITimeUpdateStyle showSytle;

	public bool UseRealWorldTime;

	public Action m_FinishCallBackFn;

	public int LastSeconds => 0;

	public EUITimeUpdateType TimeUpdateMethod => EUITimeUpdateType.Stable;

	public string ExtraLocKeyNeedParam
	{
		set
		{
		}
	}

	public void Init(object[] data)
	{
	}

	public void Clear()
	{
	}

	public void Update()
	{
	}

	public float GetSeconds()
	{
		return 0f;
	}

	private void UpdateTimeSeconds(int seconds)
	{
	}

	public bool IsTimeout()
	{
		return false;
	}

	public void CheckFinish(int seconds)
	{
	}

	public void StopTicking()
	{
	}

	public void ChangeTargetTime(float newTargetTime)
	{
	}

	public void SetLocKey(string key)
	{
	}
}
