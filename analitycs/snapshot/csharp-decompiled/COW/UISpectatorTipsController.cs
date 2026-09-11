using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UISpectatorTipsController : UIPopupWindowController
{
	public enum ETipsItemType
	{
		TipsItem,
		InGameTitle,
		MatchResultTitle
	}

	private const uint TTTLE_HEIGHT = 39u;

	private const uint TIPS_ITEM_HEIGHT = 30u;

	private const int TITLE_OFFSET = 6;

	private const int TIPS_OFFSET = 5;

	private const int BG_OFFSET = 9;

	private Vector2 ITEM_SIZE;

	private Vector2 TITLE_SIZE;

	private UISpectatorTipsView m_View;

	private List<SpectatorInteractionInfo> m_SpectatorDataList;

	private float m_Offset;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitTipsItemTemplate()
	{
	}

	private void RefreshHeight(int spectatorItemCount, int matchResultCount)
	{
	}

	private void RefreshTableView(List<SpectatorInteractionInfo> spectatorData, List<SpectatorInteractionInfo> matchData)
	{
	}

	public void SetViewData(Vector3 pos, List<SpectatorInteractionInfo> data, List<SpectatorInteractionInfo> matchData)
	{
	}

	private void SetPosition(Vector3 itemPos)
	{
	}

	private UITable2.IUITable2Item _003CInitTipsItemTemplate_003Eb__13_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTipsItemTemplate_003Eb__13_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTipsItemTemplate_003Eb__13_2()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
