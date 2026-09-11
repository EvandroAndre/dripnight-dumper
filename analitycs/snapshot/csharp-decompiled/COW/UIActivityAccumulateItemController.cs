using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityAccumulateItemController : UIBaseController
{
	private UIModelActivity m_Model;

	private UIActivityAccumulateItemView m_View;

	public ClientActivityDesc m_Desc;

	private ActivityClientInfo m_Info;

	private UIStandardItemMiniController m_ItemController;

	private GameObject m_RewardGetEffect;

	private bool _003CShowModel_003Ek__BackingField;

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

	protected override void OnUIDestroy()
	{
	}

	public void RefreshDataInfo()
	{
	}

	public void SetViewData(ClientActivityDesc desc, bool isLast = false)
	{
	}

	public void RefreshItemState()
	{
	}

	private void OnClickItem()
	{
	}

	public void SetWidth(int width)
	{
	}

	public uint GetCdtValue()
	{
		return 0u;
	}

	public uint GetTaskData()
	{
		return 0u;
	}

	public EActivity.State GetState()
	{
		return EActivity.State.State_RECEIVED;
	}

	public void CalculateProgressValue(uint lastcdtValue)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
