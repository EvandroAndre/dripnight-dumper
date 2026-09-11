using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGameModeMapPickItemController : UIBaseController, IUIModelDataChangeObserver
{
	public enum LockType
	{
		None,
		Rank,
		Level
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public UIGameModeMapPickItemController _003C_003E4__this;

		public List<ResourceID> listNeedDownloadMapRes;

		internal void _003CRefreshDownloadState_003Eb__0()
		{
		}
	}

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelLadderMatch m_LadderMatch;

	private UIModelCSLadderMatch m_CSLadderMatch;

	private UIGameModeMapPickItemView m_View;

	private LockType m_LockType;

	private bool m_Selected;

	public bool forchMatch;

	public MapModeData MapData;

	private UINewDownloadInfoController m_DownloadCtrl;

	private List<uint> m_RankLimitMapList;

	private uint m_ModeMaxLadder;

	private uint m_ModeUnLockLevel;

	private bool m_ShowFrame;

	private bool IsLock => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void SetData(MapModeData data)
	{
	}

	private bool MapIsInRankLImit()
	{
		return false;
	}

	private LockType GetLockType()
	{
		return LockType.None;
	}

	private void RefreshRankMap()
	{
	}

	public void RefreshViewByRankMap()
	{
	}

	public void TrySelect()
	{
	}

	public void TryUnselect()
	{
	}

	public bool IsSelected()
	{
		return false;
	}

	private void RefreshView()
	{
	}

	private void RefreshForceMatch()
	{
	}

	private void RefreshDownloadState()
	{
	}

	private bool RefreshLock()
	{
		return false;
	}

	private void RefreshTopView()
	{
	}

	private void RefreshOpenTime()
	{
	}

	private void OnClickBtnPick()
	{
	}

	private void OnMapProtectionClick()
	{
	}

	private List<ResourceID> GetNeedDownloadMapResList()
	{
		return null;
	}

	public bool CanPick()
	{
		return false;
	}

	private bool _003CIsSelected_003Eb__27_0(MapModeData x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
