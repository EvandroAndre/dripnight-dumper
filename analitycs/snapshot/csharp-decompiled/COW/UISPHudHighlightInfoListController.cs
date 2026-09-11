using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudHighlightInfoListController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<byte, byte> _003C_003E9__21_0;

		internal byte _003CInitializeHighlightData_003Eb__21_0(byte t)
		{
			return 0;
		}
	}

	private UISPHudHighlightInfoListView m_View;

	private UIModelSpectator m_ModelSpectator;

	private ReplayManager m_ReplayManager;

	private bool m_IsVisible;

	private bool m_IsDataInitialized;

	private UIPopMenuSmallControler m_HighlightTypeFilterMenu;

	private EHighLightPlayType m_CurrentFilterType;

	private Dictionary<ulong, UISPHudHighlightPlayerInfoController> m_PlayerCtrls;

	private Dictionary<ulong, List<UISPHudHighlightPlayItemController>> m_PlayerHighlightCtrls;

	private Dictionary<ulong, bool> m_PlayerExpandState;

	private UISPHudHighlightPlayItemController m_PlayingHighlightCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPlayerHighlightOver(bool isOver)
	{
	}

	private void InitFilterMenu()
	{
	}

	private void GenerateFilterMenuData()
	{
	}

	private void OnFilterTypeSelected(object data)
	{
	}

	private string GetFilterTypeText(EHighLightPlayType type)
	{
		return null;
	}

	private void OnCloseClick()
	{
	}

	private void OnOpenHighlightInfoList()
	{
	}

	public void ShowPanel(bool show)
	{
	}

	private void InitializeHighlightData()
	{
	}

	private bool HasAnyHighlightEvents(PlayerHighlightInfo playerHighlight)
	{
		return false;
	}

	private void CreatePlayerHighlightCtrls(Transform container, ulong userID, PlayerHighlightInfo playerHighlight, List<UISPHudHighlightPlayItemController> targetList)
	{
	}

	private int GetHighlightKillCount(PlayerHighlightInfo playerHighlight, EHighLightPlayType type)
	{
		return 0;
	}

	public void OnPlayerExpandToggle(ulong userID)
	{
	}

	private void RefreshPlayerHighlights(ulong userID)
	{
	}

	public void FilterHighlightType(EHighLightPlayType filterType)
	{
	}

	public void OnHighlightItemClick(ulong userID, EHighLightPlayType highlightType, UISPHudHighlightPlayItemController clickedCtrl = null)
	{
	}

	private void RefreshAllPlayingState()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
