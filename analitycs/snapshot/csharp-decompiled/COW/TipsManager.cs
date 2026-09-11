using System.Collections.Generic;
using GCommon;

namespace COW;

public class TipsManager : SingletonModule<TipsManager>
{
	private Dictionary<int, int> m_TipsDataStore;

	private Dictionary<int, List<ITipsDelegate>> m_TipsDelegates;

	private Dictionary<string, CSVBaseData> m_ShowRuleDict;

	private Dictionary<string, CSVBaseData> m_SpShowRuleDict;

	private Dictionary<string, CSVBaseData> m_BubbleShowRuleDict;

	protected override void OnInit()
	{
	}

	public void OnLogout()
	{
	}

	public void CleanDelegateCache()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void SetTipsNum(ETipsType type, int num)
	{
	}

	public TipsGoShowRuleData GetSettingDataByType(ETipsType tipsType)
	{
		return null;
	}

	public bool CheckCanShowSPTip(ESpTipsType spTipType)
	{
		return false;
	}

	private uint GetSpTipLevelLimit(ESpTipsType spTipType)
	{
		return 0u;
	}

	private SpTipsGoShowRuleData GetSpTipShowRuleData(ESpTipsType spTipType)
	{
		return null;
	}

	public int GetTipsNum(ETipsType type)
	{
		return 0;
	}

	public void AddTipsNum(ETipsType type, int num)
	{
	}

	public void ClearTipsNum(ETipsType type)
	{
	}

	public void ClearTipsNumIncludeChild(ETipsType type)
	{
	}

	public void ClearParentTipsWithoutChild(ETipsType type)
	{
	}

	public void RegisterTipsDelegate(ETipsType type, ITipsDelegate del)
	{
	}

	public void UnRegisterTipsDelegate(ETipsType type, ITipsDelegate del)
	{
	}

	public void NotifyTipsChange(ETipsType type)
	{
	}

	private List<ITipsDelegate> GetDelegateList(ETipsType type)
	{
		return null;
	}

	public bool CheckCanShowBubble(EBubbleType bubbleType)
	{
		return false;
	}

	private uint GetBubbleLevelLimit(EBubbleType bubbleType)
	{
		return 0u;
	}

	private BubbleShowRuleData GetBubbleShowRuleData(EBubbleType bubbleType)
	{
		return null;
	}
}
