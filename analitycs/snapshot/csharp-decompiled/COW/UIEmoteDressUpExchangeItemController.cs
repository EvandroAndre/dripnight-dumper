using GCommon;
using UnityEngine;

namespace COW;

public class UIEmoteDressUpExchangeItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIEmoteDressUpExchangeItemView m_View;

	private UIModelDressUp m_Model;

	private UIModelEvoPass m_ModelEvoPass;

	private DressUpCardState m_state;

	private uint m_Slotid;

	private ulong mytime;

	private UINewDownloadInfoController m_Downloader;

	private GameObject m_DesgarMask;

	private DressUpMaskType m_DressUpMaskType;

	protected override void OnUIInit()
	{
	}

	private void OnBtnClick()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void UpdateDressUpItemDownloadStatus(DressUpMaskType dressUpMaskType = DressUpMaskType.None)
	{
	}

	public void SetUIData(uint index, uint slotID)
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
}
