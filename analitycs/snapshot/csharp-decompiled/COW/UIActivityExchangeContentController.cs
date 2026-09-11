using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityExchangeContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ClientActivityDesc> _003C_003E9__15_0;

		public static Comparison<ClientActivityDesc> _003C_003E9__15_1;

		public static Comparison<ClientActivityDesc> _003C_003E9__15_2;

		internal int _003CCreateEventDescList_003Eb__15_0(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}

		internal int _003CCreateEventDescList_003Eb__15_1(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}

		internal int _003CCreateEventDescList_003Eb__15_2(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}
	}

	private UIActivityExchangeContentView m_View;

	private UIModelActivity m_ModelActivity;

	private UIModelInventory m_ModelInventory;

	private List<ClientActivityDesc> m_Descs;

	private List<UIActivityExchangeItemController> m_ExchangeDescUIs;

	public Dictionary<ulong, uint> m_OneFromNActivityIds;

	private Queue<UIActivityExchangeItemController> m_UIActivityExchangeItemPool;

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

	private UIActivityExchangeItemController GetUIActivityExchangeItemControllerFromPool(Transform parentTransform)
	{
		return null;
	}

	private void ReturnUIActivityExchangeItemControllerToPool(UIActivityExchangeItemController exchangeItem)
	{
	}

	public void ResetUI()
	{
	}

	public override void SetData(object data)
	{
	}

	private bool HaveExchangeOneFromN()
	{
		return false;
	}

	private void CreateEventDescList(bool haveExchangeOneFromN)
	{
	}

	private UIActivityExchangeItemController CreateEventDesc(ClientActivityDesc desc, List<AwardDesc> awards)
	{
		return null;
	}

	private UIActivityExchangeItemController CreateEventDesc(ClientActivityDesc desc)
	{
		return null;
	}

	public override void Reload()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
