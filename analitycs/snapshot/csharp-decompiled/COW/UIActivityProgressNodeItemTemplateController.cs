using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIActivityProgressNodeItemTemplateController : UIBaseController
{
	private uint _003CTemplateGroupId_003Ek__BackingField;

	private UIModelActivity m_Model;

	private UIActivityProgressNodeItemTemplateView m_View;

	public ClientActivityDesc m_Desc;

	private ActivityClientInfo m_Info;

	private UIStandardItemMiniController m_ItemController;

	private GameObject m_RewardGetEffect;

	private const float NormalItemRootScale = 0.9f;

	private const float BigPrizeItemRootScale = 1f;

	private bool _003CShowModel_003Ek__BackingField;

	public uint TemplateGroupId
	{
		get
		{
			return _003CTemplateGroupId_003Ek__BackingField;
		}
		set
		{
			_003CTemplateGroupId_003Ek__BackingField = value;
		}
	}

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

	private void ApplyProgressBarSkin()
	{
	}

	public void RefreshItemState()
	{
	}

	private static void SetCdn(UINetworkTexture target, string url)
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
