using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIAvatarAwakenStoryReplayController : UIBaseController, IUIModelDataChangeObserver
{
	private UIAvatarAwakenStoryReplayView m_View;

	private UIModelAvatarProfile m_Model;

	private RewardWndCfg m_PendingRewardCfg;

	private List<UIPanel> m_ComicPosList;

	private AvatarProfile m_CurrentShowAvatar;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetAvatar(uint curAvatarID)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void InitStoryList()
	{
	}

	private int SortItem(AvatarAwakenComicData a, AvatarAwakenComicData b)
	{
		return 0;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
