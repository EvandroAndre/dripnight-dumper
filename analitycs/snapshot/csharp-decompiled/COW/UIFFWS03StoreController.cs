using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIFFWS03StoreController : UIBigEventStoreBaseController, IUIModelDataChangeObserver
{
	public enum ETabType
	{
		None,
		Store1,
		Store2
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__18_0;

		internal CommonRewardItemInfo _003COnDataChanged_003Eb__18_0(BaseItemInfo item)
		{
			return null;
		}
	}

	private UIFFWS03StoreView m_View;

	private List<LimitedEventStore> m_StoreDataList;

	private UIModelBigEvent m_ModelBigEvent;

	private UIModelFFWS03 m_ModelFFWS03;

	private UIFFWS03TopBtnController m_TopBtnCtrl;

	private GameObject[] m_RedPointArray;

	private ETabType m_StoreTabType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	public override UIBigEventStoreItemBaseController GetStoreItemController()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshView()
	{
	}

	private void OnBtnSwitchRedPointClick()
	{
	}

	private void OnBtnRuleClick()
	{
	}

	private void OnTopTabSelect(ETabType tabType, bool isForce = false)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__12_0()
	{
	}

	private void _003COnUIInit_003Eb__12_1()
	{
	}

	private void _003CRefreshView_003Eb__14_0()
	{
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	public UIBigEventStoreItemBaseController _003C_003EiFixBaseProxy_GetStoreItemController()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
