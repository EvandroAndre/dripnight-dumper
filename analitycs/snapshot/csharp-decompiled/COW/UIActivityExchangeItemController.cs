using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityExchangeItemController : UIBaseController
{
	private enum OperateStatus
	{
		None,
		Exchange,
		ExchangeNo,
		ExchangeFinished,
		ExchangeNoByOwner
	}

	private List<UIStandardItemMiniController> m_ConsumeItemUIs;

	private List<UIStandardItemMiniController> m_AwardItemUIs;

	private UIActivityExchangeItemView m_View;

	private string UNLIMITED_STRING;

	private const int tokenDragThresholdNum = 2;

	private const int rewardDragThresholdNum = 2;

	private Dictionary<ulong, uint> m_OneFromNActivityIds;

	private List<AwardDesc> m_OneFromNAward;

	private Queue<UIStandardItemMiniController> m_UIStandardItemMiniPool;

	private OperateStatus m_OperateStatus;

	private UIModelActivity m_ModelActivity;

	private ClientActivityDesc m_Desc;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetVFXResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ResetUI()
	{
	}

	private UIStandardItemMiniController GetUIStandardItemMiniControllerFromPool(Transform parentTransform)
	{
		return null;
	}

	private void ReturnUIStandardItemMiniControllerToPool(UIStandardItemMiniController itemMini)
	{
	}

	protected virtual object CreateView()
	{
		return null;
	}

	public void SetData(ClientActivityDesc desc, Dictionary<ulong, uint> OneFromNActivityIds, List<AwardDesc> awards)
	{
	}

	public void SetData(ClientActivityDesc desc)
	{
	}

	private void SetOperateButtonUI()
	{
	}

	private void OnRedTipsOnOffClicked()
	{
	}

	private void SetRedTipsOnOff(bool open)
	{
	}

	private void CreateConsumeItems()
	{
	}

	private void CreateAwardItems(List<AwardDesc> awards)
	{
	}

	private void PlayBtnAnimation()
	{
	}

	private void OnOperate()
	{
	}

	public void Reload()
	{
	}

	public string CalcCount(BaseItemInfo data)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
