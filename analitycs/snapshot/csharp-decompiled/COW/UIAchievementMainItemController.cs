using GCommon;
using UnityEngine;

namespace COW;

internal class UIAchievementMainItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	private uint m_AchievementId;

	private UIAchievementMainItemView m_View;

	private UIModelAchievement m_Model;

	private bool m_IsNewCompletedAchievement;

	private GameObject m_GlowEffect;

	private Animation m_NewGainAnim;

	private uint m_UIFXType;

	private const uint NEW_PLAYER_EXPLORE_ACHIEVEMENT_ID = 32013u;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshNewPlayerExploreAchievementIcon()
	{
	}

	public void SkipAnim()
	{
	}

	public void ResetAnim()
	{
	}

	public void PlayAnim()
	{
	}

	private void PlayNewCompletedAnim()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	private void OnEggAchievementBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
