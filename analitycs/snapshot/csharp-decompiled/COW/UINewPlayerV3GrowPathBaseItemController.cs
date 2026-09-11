using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UINewPlayerV3GrowPathBaseItemController : UIBaseController, UITable2.IUITable2Item
{
	protected UIModelNewPlayerV3 m_ModelNewPlayerV3;

	private UINewPlayerV3GrowPathAwardItemController m_ItemAwardController;

	protected NewPlayerGrowPathData m_GrowPathData;

	protected NewPlayerGrowPathBaseItemView m_BaseView;

	private int m_DefaultItemWidth;

	private int m_Index;

	private UINewPlayerV3GrowPathController m_ParentCtrl;

	private Action<Vector3, List<AwardDesc>, uint> m_DetailAwardPopAction;

	private int SINGLE_OFFSET;

	private int DOUBLE_OFFSET;

	private int HEAD_OFFSET;

	protected NewPlayerGrowPathBaseItemView BaseView => null;

	private UINewPlayerV3GrowPathController ParentCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public virtual void RefreshView(object data, int index)
	{
	}

	private void ResetProgressWidth()
	{
	}

	private void SetProgressUI()
	{
	}

	private void SetProgressOffset()
	{
	}

	private void SetMainOffset()
	{
	}

	private void SetTransformPosX(int offestX, Transform transform)
	{
	}

	private int GetLastSelectIndex()
	{
		return 0;
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void ShowPreview()
	{
	}

	private void OnSelectButtonClick()
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void OnItemBtnUnSelect()
	{
	}

	public void SetDetailAwardPopOpenAction(Action<Vector3, List<AwardDesc>, uint> action)
	{
	}

	public void DetailAwardPopOpenCallBack(Vector3 startfrom, List<AwardDesc> awardDescs, uint level)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
