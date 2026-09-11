using GCommon;
using UnityEngine;

namespace COW;

public class UIRecommendLoadoutWindowRecommenderTabController : UIBaseController
{
	public enum TabLevel
	{
		Mode,
		Recommender
	}

	public enum ETabDisplayState
	{
		Mid,
		Left,
		Right
	}

	private UIRecommendLoadoutWindowRecommenderTabView m_View;

	private uint m_TabId;

	private GameObject BGSelected;

	private GameObject BGUnselected;

	private TabLevel m_TabLevel;

	private uint m_RecommenderType;

	private UITipsNormalController m_TipsCtrl;

	public uint TabId => 0u;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnClickItem()
	{
	}

	public void SetId(uint id)
	{
	}

	public void SetAsRecommender(uint recommenderType)
	{
	}

	public void SetAsMode()
	{
	}

	public uint GetRecommenderType()
	{
		return 0u;
	}

	public void SetTitle(string title)
	{
	}

	public void SetState(bool state)
	{
	}

	public void SetVBadge(bool state)
	{
	}

	public void SetTabDisplayState(ETabDisplayState state)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
