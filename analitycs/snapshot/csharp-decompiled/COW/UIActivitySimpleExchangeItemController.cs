using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivitySimpleExchangeItemController : UIBaseController
{
	private enum OperateStatus
	{
		None,
		Exchange,
		ExchangeNo,
		ExchangeFinished,
		ExchangeNoByOwner
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public AwardDesc award;

		internal void _003CCreateAwardItems_003Eb__0()
		{
		}
	}

	private List<UIStandardItemMiniController> m_ConsumeItemUIs;

	private List<UIStandardItemMiniController> m_AwardItemUIs;

	private UIActivitySimpleExchangeItemView m_View;

	private string UNLIMITED_STRING;

	private const int tokenDragThresholdNum = 2;

	private const int rewardDragThresholdNum = 2;

	private Dictionary<ulong, uint> m_OneFromNActivityIds;

	private List<AwardDesc> m_OneFromNAward;

	private List<GameObject> mSymbolList;

	private Queue<UIStandardItemMiniController> m_UIStandardItemMiniPool;

	private bool _003CShowModel_003Ek__BackingField;

	private OperateStatus m_OperateStatus;

	private UIModelActivity m_ModelActivity;

	private ClientActivityDesc m_Desc;

	private uint DelayCallID;

	public bool ShowModel
	{
		get
		{
			return _003CShowModel_003Ek__BackingField;
		}
		set
		{
			_003CShowModel_003Ek__BackingField = value;
		}
	}

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

	private void PlayShowAnimation(int index)
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

	public void SetData(ClientActivityDesc desc, Dictionary<ulong, uint> OneFromNActivityIds, List<AwardDesc> awards, int index)
	{
	}

	public void SetData(ClientActivityDesc desc, int index)
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

	private void _003CPlayShowAnimation_003Eb__22_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
