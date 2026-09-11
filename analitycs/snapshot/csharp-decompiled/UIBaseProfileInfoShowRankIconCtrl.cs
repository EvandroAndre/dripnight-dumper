using System.Collections.Generic;
using UnityEngine;

public class UIBaseProfileInfoShowRankIconCtrl : MonoBehaviour
{
	public GameObject CSRankIconContainer;

	public GameObject CSPeakTournamentRankIconContainer;

	public UIWrapContent WrapContent;

	private UICenterOnChild WrapCenter;

	private List<GameObject> m_RankIconContainers;

	private uint m_AutoScrollDelayCallID;

	private int m_LastSelectedIndex;

	private bool m_isInit;

	public void InitContainer(bool showCS, bool showPeak)
	{
	}

	private void AutoSwitchIcon()
	{
	}

	public void CancelAutoSwitch()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
