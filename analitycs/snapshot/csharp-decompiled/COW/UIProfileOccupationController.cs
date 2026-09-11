using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileOccupationController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<OccupationItemViewData> _003C_003E9__31_0;

		public static Comparison<OccupationItemViewData> _003C_003E9__31_1;

		public static Comparison<CirclePieChartData> _003C_003E9__31_2;

		public static Comparison<CirclePieChartData> _003C_003E9__37_0;

		internal int _003CRefreshViewData_003Eb__31_0(OccupationItemViewData x, OccupationItemViewData y)
		{
			return 0;
		}

		internal int _003CRefreshViewData_003Eb__31_1(OccupationItemViewData x, OccupationItemViewData y)
		{
			return 0;
		}

		internal int _003CRefreshViewData_003Eb__31_2(CirclePieChartData x, CirclePieChartData y)
		{
			return 0;
		}

		internal int _003CGenreateItemViewData_003Eb__37_0(CirclePieChartData x, CirclePieChartData y)
		{
			return 0;
		}
	}

	private UIProfileOccupationView m_View;

	private UICirclePieChartController m_PieChartCtrl;

	private UIOccupationDetailInfoItemController m_DetailInfoItemCtrl;

	private List<UIProfileOccupationItemController> m_Items;

	private List<CirclePieChartData> m_PieChartDatas;

	private List<OccupationItemViewData> m_ItemsViewDatas;

	private OccupationDetailInfo m_ShownInfo;

	private GameObject BANNEROU;

	private ulong m_AccountId;

	private uint m_DelayCall;

	private OccpuationData m_Data;

	private UIModelProfile m_ModelProfile;

	private UIPopMenuBigController m_CareerMenu;

	private List<string> m_CareerStrList;

	private string m_CareerSelected;

	private Vector3 CenterTargetScale;

	private Vector3 CirclePieOffset;

	private Vector3 CirclePieChartTargetScale;

	private uint m_ShowingMatchMode;

	public uint ShowingMatchMode => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void GenerateModeBrMenu()
	{
	}

	private void OnCareerMenuSelect(object obj)
	{
	}

	public void RefreshViewDataBR()
	{
	}

	public void RefreshViewDataCS()
	{
	}

	public void RefreshViewDataCSPEAK()
	{
	}

	private void InitPopMenu()
	{
	}

	private void UpdatePopMenuAnchor()
	{
	}

	private void RefreshViewData()
	{
	}

	public void OnItemsClicked(uint clickedId)
	{
	}

	private bool IsCurShowingMatchModeSeasonOK()
	{
		return false;
	}

	public void OnItemChosenClicked(uint chosenId)
	{
	}

	private bool TryShowCirclePieChart()
	{
		return false;
	}

	private void GetItemViewData()
	{
	}

	private void GenreateItemViewData(OccupationDetailInfo data, uint matchMode, bool isSeason)
	{
	}

	private NameplateViewData GetNamesplateData(uint occupationId, OccupationDetailInfo data, string title)
	{
		return null;
	}

	private string GetWeaponName(uint id)
	{
		return null;
	}

	private void ShowSelfOnlyUI()
	{
	}

	private void OnCheckBoxTipsClicked()
	{
	}

	private void OnCheckBoxClicked()
	{
	}

	private void RefreshCheckBoxStates()
	{
	}

	private void OnHelpBtnClicked()
	{
	}

	private void OnShareBtnClicked()
	{
	}

	public void OnShareDataReady()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void SetAccountID(ulong accountID)
	{
	}

	private void ShowSeasonBanner()
	{
	}

	private void OnShowBanner()
	{
	}

	private static int GetOccupationItemDataScore(uint id)
	{
		return 0;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnShareDataReady_003Eb__46_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
