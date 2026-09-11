using System.Collections.Generic;
using GCommon;

namespace COW;

public class GiftRewardPopupManager : SingletonModule<GiftRewardPopupManager>
{
	private List<GiftRewardPopupData> m_GiftMailList;

	private int m_CurrentPopupIndex;

	private int m_GiftMailCount;

	public bool m_Finished;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void ShowAwardList(List<GiftRewardPopupData> data)
	{
	}

	public void PopupNextRewards(object[] data)
	{
	}
}
