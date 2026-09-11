using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonYearMainBaseController : UIBaseController, IUIModelDataChangeObserver
{
	protected bool m_HasStartMainAnim;

	protected UIModelSeasonYear m_ModelSeasonYear;

	protected UIModelActivity m_ModelActivity;

	protected UIModelSeasonYear m_SeasonYear;

	protected uint m_SeasonYearId;

	protected bool m_GetCurSeasonYearBRHistoryStats;

	protected bool m_GetCurSeasonYearCSHistoryStats;

	protected List<UISeasonYearHeroicPointController> m_CSHeroicPointList;

	protected List<UISeasonYearHeroicPointController> m_BRHeroicPointList;

	protected List<UISeasonYearRewardItemController> m_RewardItemList;

	protected Dictionary<uint, float> m_ProgressValueDict;

	protected GameObject[] m_ProgressNode;

	protected ESeasonYearMainAnimType m_MainAnimType;

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected virtual void OnPlayStartAnim(object[] data)
	{
	}

	protected virtual void OnPlaySwitchAnim(uint seasonYearId)
	{
	}

	protected virtual void SetPointView()
	{
	}

	protected virtual void InitProgressDict()
	{
	}

	public virtual void PlayMainAnim(int animType)
	{
	}

	protected virtual void SetHeroicCntAndProgressView()
	{
	}

	protected virtual void SetBRHeroicPointsView()
	{
	}

	protected virtual void SetCSHeroicPointsView()
	{
	}

	protected virtual void SetRewardView()
	{
	}

	protected virtual uint GetSeasonYearId()
	{
		return 0u;
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
