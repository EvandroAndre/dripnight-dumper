using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityTokenExchangeContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ClientActivityDesc> _003C_003E9__21_0;

		public static Comparison<ClientActivityDesc> _003C_003E9__21_1;

		public static Comparison<ClientActivityDesc> _003C_003E9__21_2;

		internal int _003CCreateEventDescList_003Eb__21_0(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}

		internal int _003CCreateEventDescList_003Eb__21_1(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}

		internal int _003CCreateEventDescList_003Eb__21_2(ClientActivityDesc x, ClientActivityDesc y)
		{
			return 0;
		}
	}

	private UIActivityTokenExchangeContentView m_View;

	private UIModelActivity m_ModelActivity;

	private UIModelInventory m_ModelInventory;

	private List<ClientActivityDesc> m_Descs;

	private List<UIActivitySimpleExchangeItemController> m_ExchangeDescUIs;

	public Dictionary<ulong, uint> m_OneFromNActivityIds;

	private Queue<UIActivitySimpleExchangeItemController> m_UIActivityExchangeItemPool;

	private List<uint> m_TokenList;

	private List<UILabel> m_TokenNumList;

	private bool m_ShowModel;

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

	private UIActivitySimpleExchangeItemController GetUIActivityExchangeItemControllerFromPool(Transform parentTransform)
	{
		return null;
	}

	private void ReturnUIActivityExchangeItemControllerToPool(UIActivitySimpleExchangeItemController exchangeItem)
	{
	}

	public void ResetUI()
	{
	}

	public override void SetData(object data)
	{
	}

	private void CreateExchangeToken()
	{
	}

	private void SetTokenIcon(UISprite tokenIcon, uint itemId)
	{
	}

	private static void SetTokenLabel(UILabel tokenLabel, uint itemId)
	{
	}

	private bool HaveExchangeOneFromN()
	{
		return false;
	}

	private void CreateEventDescList(bool haveExchangeOneFromN)
	{
	}

	private UIActivitySimpleExchangeItemController CreateEventDesc(ClientActivityDesc desc, List<AwardDesc> awards, int index)
	{
		return null;
	}

	private UIActivitySimpleExchangeItemController CreateEventDesc(ClientActivityDesc desc, int index)
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
