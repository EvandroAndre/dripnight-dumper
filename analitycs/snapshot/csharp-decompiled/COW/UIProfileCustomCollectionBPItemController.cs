using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileCustomCollectionBPItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<BasicEPInfo> _003C_003E9__15_0;

		internal int _003CUpdateEpAwardUIList_003Eb__15_0(BasicEPInfo x, BasicEPInfo y)
		{
			return 0;
		}
	}

	private UIProfileCustomCollectionBPItemView m_View;

	private UIModelProfile m_ModelProfile;

	private UIModelBooyahPass m_ModelBP;

	private List<BasicEPInfo> m_AllEpList;

	private UIprofileEpsmallController[] m_EPCtrlList;

	private HashSet<uint> m_EventIDs;

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

	protected override ProfileCustomDragDropItem GetDragDropItem()
	{
		return null;
	}

	public override GameObject GetIcon()
	{
		return null;
	}

	protected override void CaclulateItemOffset()
	{
	}

	public override void SetViewData(ProfileCustomModuleData data)
	{
	}

	private void UpdatePersonBpInfo()
	{
	}

	private void UpdateOtherPersonBpInfo(List<BasicEPInfo> list)
	{
	}

	private void UpdateEpAwardUIList(List<BasicEPInfo> historyinfo, int currentEpCnt)
	{
	}

	private void OnBpBriefClick()
	{
	}

	private void OnUIUpdate(int dataSource, int moduleId)
	{
	}

	public override void ShowBgByBriefBox()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_CaclulateItemOffset()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(ProfileCustomModuleData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowBgByBriefBox()
	{
	}
}
