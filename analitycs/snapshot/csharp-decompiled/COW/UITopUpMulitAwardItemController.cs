using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UITopUpMulitAwardItemController : UIBaseController, IUIActivityTask
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public AwardDesc award;

		internal void _003CCreateAwardItems_003Eb__0()
		{
		}
	}

	private List<ClientActivityDesc> m_DescList;

	private UITopUpMulitAwardItemView m_View;

	private UIModelActivity m_Model;

	private List<UIStandardItemMiniController> m_ItemList;

	private List<GameObject> mSymbolList;

	private List<AwardDesc> m_Rewards;

	private EActivity.State m_State;

	private uint DelayCallID;

	private UITopUpEventController.TopUpEventPageType m_TopUpEventPageType;

	private bool _003CShowModel_003Ek__BackingField;

	public GameObject RootObject => null;

	public uint ItemType => 0u;

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

	public EActivity.State GetState()
	{
		return EActivity.State.State_RECEIVED;
	}

	public uint GetRewardActivityId()
	{
		return 0u;
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

	public void PlayShowAnimation(int index)
	{
	}

	public void SetData(List<ClientActivityDesc> list, int index)
	{
	}

	public void Reload()
	{
	}

	public void RefreshItemState()
	{
	}

	private void CreateAwardItems(List<AwardDesc> awards)
	{
	}

	public void ResetUI()
	{
	}

	private void OnTopUpClick()
	{
	}

	private void OnCliamClick()
	{
	}

	public void SetScrollView(UIScrollView scrollView)
	{
	}

	private void _003CPlayShowAnimation_003Eb__22_0()
	{
	}

	private void _003COnCliamClick_003Eb__29_0(uint activityId)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
