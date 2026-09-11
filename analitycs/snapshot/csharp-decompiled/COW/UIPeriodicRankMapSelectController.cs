using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPeriodicRankMapSelectController : UIBaseController, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIPeriodicRankMapSelectItemController> _003C_003E9__14_0;

		internal int _003CShowMapItemAnim_003Eb__14_0(UIPeriodicRankMapSelectItemController x, UIPeriodicRankMapSelectItemController y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UIPeriodicRankMapSelectItemController item;

		internal void _003CShowMapItemAnim_003Eb__2()
		{
		}
	}

	private UIPeriodicRankMapSelectView m_View;

	private UIModelPeriodicLadderMatch m_Model;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private uint m_CurrentSelectConfigID;

	private bool m_IsForceRandom;

	private uint m_CurrentSeasonGameMode;

	private string m_RankKey;

	private List<UICommonGuideController> m_GuideController;

	private Dictionary<uint, bool> m_PeriodicMapSelectDict;

	private List<uint> m_AnimDelayCalls;

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

	public void SetViewData()
	{
	}

	private void ShowMapItemAnim()
	{
	}

	private void ClearDelayCalls()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnPeriodicLadderMapSelectChanged(object[] param)
	{
	}

	private void OnPeriodicLadderMapSelectRefresh(object[] param)
	{
	}

	private void DataChanged()
	{
	}

	private void RefreshList(List<MapOpeningInfo> mapList, bool keep_page = false)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnConfirmButtonClick()
	{
	}

	private void _003CShowMapItemAnim_003Eb__14_1()
	{
	}

	private void _003COnVisibilityChanged_003Eb__16_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
