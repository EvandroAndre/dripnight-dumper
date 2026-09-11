using GCommon;
using UnityEngine;

namespace COW;

public class UIOnlineMatchEntranceItemController : UIBaseController
{
	private UIChampionshipEntranceItemView m_View;

	private bool m_OpenDetailedInfo;

	private Vector3 SHOWDETAILENDPOS;

	private Vector3 MOVELEFTENDPOS;

	private Vector3 MOVERIGHTENDPOS;

	public readonly string[] m_DayInWeekKey;

	private int m_Index;

	private float m_MoveAnimDuration;

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void AnimationEventHandler(object[] data)
	{
	}

	protected virtual void OnEntranceAnimFinish()
	{
	}

	public void OpenDetailedInfo()
	{
	}

	public void CloseDetailedInfo()
	{
	}

	public void SwitchDetailedInfo(bool openDetailedInfo)
	{
	}

	private void OnShowDetailAnimFinish()
	{
	}

	public void PlayMoveLeftAnim(bool forward)
	{
	}

	public void PlayMoveRightAnim(bool forward)
	{
	}

	public virtual long GetEntranceOpenTime()
	{
		return 0L;
	}

	public virtual long GetSeasonStartTime()
	{
		return 0L;
	}

	public virtual int GetPriority()
	{
		return 0;
	}

	public virtual int GetMatchType()
	{
		return 0;
	}

	public void OnReposition()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
