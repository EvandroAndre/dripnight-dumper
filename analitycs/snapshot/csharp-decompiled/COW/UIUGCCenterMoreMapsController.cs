using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIUGCCenterMoreMapsController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum TemplateType
	{
		WaterfallItem,
		WaterfallPlaceholder
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<WorkshopCodeWithRankInfo, string> _003C_003E9__9_1;

		public static Converter<WorkshopCodeWithRankInfo, string> _003C_003E9__15_0;

		internal string _003CInitWaterfall_003Eb__9_1(WorkshopCodeWithRankInfo temp)
		{
			return null;
		}

		internal string _003CCheckExposure_003Eb__15_0(WorkshopCodeWithRankInfo temp)
		{
			return null;
		}
	}

	private UIUGCCenterMoreMapsView m_View;

	private UIModelSceneEdit m_Model;

	private WaterfallPoolData m_PoolData;

	private bool m_Table2Init;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(WaterfallPoolData poolData)
	{
	}

	private void OnMaskClick()
	{
	}

	private void InitWaterfall()
	{
	}

	private void InitTable2Templates()
	{
	}

	private void RefreshTable2Data()
	{
	}

	private void RefreshTable2WaterfallData(List<WaterfallValidData> data)
	{
	}

	private int AddWaterfallPlaceholder(int index)
	{
		return 0;
	}

	private string GetWaterfallLogInfo(int index)
	{
		return null;
	}

	private void CheckExposure()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private bool _003CInitWaterfall_003Eb__9_0(WorkshopCodeWithRankInfo temp)
	{
		return false;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__10_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__10_1()
	{
		return null;
	}

	private bool _003CCheckExposure_003Eb__15_1(WorkshopCodeWithRankInfo temp)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
