using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIGameModeMapPickWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<MapModeData, uint> _003C_003E9__18_0;

		internal uint _003COnClickConfirm_003Eb__18_0(MapModeData x)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public MapModeData mapData;

		internal bool _003CRefreshAllPickTick_003Eb__0(MapModeData x)
		{
			return false;
		}
	}

	private UIGameModeMapPickWndView m_View;

	private List<MapModeData> m_Selected;

	private uint m_GameMode;

	private uint m_MatchMode;

	private UIModelMapOpeningInfo m_ModelMap;

	private List<UIGameModeMapPickItemController> m_PickItemCtrls;

	private UIModelCSLadderMatch m_ModelCsLadder;

	private UIModelLadderMatch UIModelLadderMatch;

	private bool showRpOrLabel;

	private float RP;

	private List<MapModeData> MapDate;

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

	public void SetData(List<MapModeData> data)
	{
	}

	private void RefreshSelete()
	{
	}

	public bool CanCancel()
	{
		return false;
	}

	private void OnClickConfirm()
	{
	}

	private void OnMultiMapBonusClicked()
	{
	}

	private void SaveMaps()
	{
	}

	private void OnClickSelectAll()
	{
	}

	private void OnItemSelect(object[] data)
	{
	}

	private void RefreshAllPickTick()
	{
	}

	private bool IsPickAll()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
