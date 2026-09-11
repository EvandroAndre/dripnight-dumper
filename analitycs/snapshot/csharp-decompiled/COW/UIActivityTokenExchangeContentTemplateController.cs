using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityTokenExchangeContentTemplateController : UIActivityContentController, IUIModelDataChangeObserver
{
	private UIActivityTokenExchangeContentTemplateView m_View;

	private UIModelActivity m_ModelActivity;

	private UIModelInventory m_ModelInventory;

	private List<ClientActivityDesc> m_Descs;

	private List<UIActivityTokenExchangeItemTemplateController> m_ExchangeDescUIs;

	private Queue<UIActivityTokenExchangeItemTemplateController> m_UIActivityExchangeItemPool;

	private List<uint> m_TokenList;

	private List<UILabel> m_TokenNumList;

	public Dictionary<ulong, uint> m_OneFromNActivityIds;

	private uint m_GroupId;

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

	private UIActivityTokenExchangeItemTemplateController GetUIActivityExchangeItemControllerFromPool(Transform parentTransform)
	{
		return null;
	}

	private void ReturnUIActivityExchangeItemControllerToPool(UIActivityTokenExchangeItemTemplateController exchangeItem)
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

	private void ApplyCdnSkin()
	{
	}

	private static void SetCdnWithFallback(GameObject fallback, UINetworkTexture target, string url)
	{
	}

	private static void SetCdn(UINetworkTexture target, string url)
	{
	}

	private void ResetExchangeToken()
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

	private static int CompareExchangeDescByActivityId(ClientActivityDesc x, ClientActivityDesc y)
	{
		return 0;
	}

	private void CreateEventDescList(bool haveExchangeOneFromN)
	{
	}

	private UIActivityTokenExchangeItemTemplateController CreateEventDesc(ClientActivityDesc desc, List<AwardDesc> awards, int index)
	{
		return null;
	}

	private UIActivityTokenExchangeItemTemplateController CreateEventDesc(ClientActivityDesc desc, int index)
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
