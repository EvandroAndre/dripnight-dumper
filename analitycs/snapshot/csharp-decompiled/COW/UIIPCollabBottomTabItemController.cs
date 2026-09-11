using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIIPCollabBottomTabItemController : UIBaseController
{
	private uint m_IPCollabID;

	private int m_OwnNumber;

	private int m_TotalNumber;

	private EIPCollabItemType m_ItemType;

	private CollabDesc m_CollabDesc;

	private UIIPCollabBottomTabItemView m_View;

	private UIModelInventory m_UIModelInventory;

	private GameObject m_AllOwnVFX;

	private string m_AllOwnVFXName;

	private GameObject m_SelectVFX;

	private string m_SelectVFXName;

	private static Color32 m_SelectColor;

	private static Color32 m_UnSelectColor;

	private static Color32 m_DefaultLineColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetItemType(EIPCollabItemType itemType)
	{
	}

	public bool SetDataAndCheckShowState(uint IPCollabID)
	{
		return false;
	}

	private void RefreshLabel(int ownNumber, int totalNumber)
	{
	}

	private void RefreshBg(bool isAllOwn)
	{
	}

	private void RefreshLineColor()
	{
	}

	private void OnClickBtn()
	{
	}

	public void RefreshSelect(bool isSelect)
	{
	}

	private void RefreshRedPoint()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
