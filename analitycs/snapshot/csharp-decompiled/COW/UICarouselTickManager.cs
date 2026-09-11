using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UICarouselTickManager : MonoBehaviour
{
	public UIProgressBar ProgressBar;

	private List<UICarouselTickData> m_ListDatas;

	private List<float> m_TimePreSum;

	private int m_CurIndex;

	private int m_CurCycles;

	private float m_TickTime;

	private bool m_Start;

	private bool m_Inited;

	public void SetCarouselData(List<UICarouselTickData> datas)
	{
	}

	public void TickPause()
	{
	}

	public void TickStart()
	{
	}

	public void TickStart(int index, bool needInvokeCallBack = true)
	{
	}

	public void SysnTickIndex(int index)
	{
	}

	private void CalculateTimePreSumFromDatas()
	{
	}

	private void Tick()
	{
	}

	private void Update()
	{
	}
}
