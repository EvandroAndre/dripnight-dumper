using System.Collections.Generic;
using GCommon;

namespace COW;

public class TweenTipsManager : SingletonModule<TweenTipsManager>
{
	private const int MAX_TIPS = 6;

	private const int BASE_DEPTH = 900;

	private List<UICommonTweenTipsController> m_CachedCtrls;

	private int m_RunnigIndex;

	private int m_EmptyIndex;

	private int m_CurrentDepth;

	public string ReturnToLobbyTips;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void Clear()
	{
	}

	private UICommonTweenTipsController GetEmptyTipsController(int depth = 900)
	{
		return null;
	}

	public void ShowTips(string tips, float holdOnTime = 0f, int depth = 900)
	{
	}

	public void ShowTips(BaseItemInfo itemInfo)
	{
	}

	public void ShowTips(string text, List<ResourceID> iconResList)
	{
	}

	public void UpdateRunningIndex()
	{
	}

	public void ShowReturnToLobbyTips()
	{
	}
}
