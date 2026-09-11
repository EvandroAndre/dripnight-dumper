using System.Collections.Generic;

namespace COW;

public class InGameMutiTipsManager
{
	private const int MAX_TIPS = 6;

	private const int BASE_DEPTH = 900;

	private List<UIHudMutiTipsController> m_CachedCtrls;

	private int m_CurrentDepth;

	private List<UIHudMutiTipsController> m_RunningCtrls;

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public void ShowTips(string message, float duration, int color = -1)
	{
	}

	public void UpdateRunningList(UIHudMutiTipsController ctrl)
	{
	}
}
