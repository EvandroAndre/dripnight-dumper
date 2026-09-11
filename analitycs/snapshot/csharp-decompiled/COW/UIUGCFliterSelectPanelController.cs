using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCFliterSelectPanelController : UIBaseController
{
	private UIUGCFliterSelectPanelView m_View;

	private List<UGCFliterSelectTypeData> m_DataList;

	private List<UIUGCFliterSelectTypeController> m_ChildrenList;

	private int m_DefaultPaddingHeight;

	private Action m_MaskClickCallBack;

	private Action m_ConfirmClickCallBack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void SetViewData(List<UGCFliterSelectTypeData> list)
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	private void OnFliterMaskClick()
	{
	}

	private void OnFliterConfirmClick()
	{
	}

	public void RegisterCallBack(Action mask, Action confirm)
	{
	}

	public List<uint> GetSelectItemID()
	{
		return null;
	}

	public void RefreshSelectItemByID(List<uint> list)
	{
	}

	public void RefreshView()
	{
	}

	private void _003COnUIInit_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
