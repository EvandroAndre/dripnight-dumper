using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisItemBriefBoxInteractionBtnController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__26_0;

		internal void _003CPopSellWnd_003Eb__26_0()
		{
		}
	}

	private UIHippoCrisisItemBriefBoxInteractionBtnView m_View;

	private Vector2 m_NormalSize;

	private Vector2 m_SmallSize;

	private HippoCrisisDragSourceInfo m_CurDragSourceInfo;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private bool m_IsInventoryItem;

	private bool m_IsCanDragItem;

	private bool m_WaitingModifyEquip;

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

	public void SetViewData(HippoCrisisItemBriefBoxBtnData data)
	{
	}

	public UIWidget GetGuideWidget()
	{
		return null;
	}

	public UIButton GetGuideButton()
	{
		return null;
	}

	private void SetBtnSize(EHCBriefBoxBtnSizeType sizeType)
	{
	}

	private void OnClickEquipBtn()
	{
	}

	private void OnSetToStorageBinBtn()
	{
	}

	private void OnClickSetToBagBtn()
	{
	}

	private void OnClickSellBtn()
	{
	}

	private void OnClickUnEquipBtn()
	{
	}

	private void OnClickBuyBtn()
	{
	}

	private void OnClickDropBtn()
	{
	}

	private void OnClickSetToInventoryBtn()
	{
	}

	private void CheckAndCloseBriefBox(HippoCrisisDragOperationResult dragOperationResult)
	{
	}

	private void BtnReponse(HippoCrisisDragOperationResult dragOperationResult, HippoCrisisDragSourceInfo info)
	{
	}

	private void HideBriefBox()
	{
	}

	private void PopSellWnd()
	{
	}

	private void CheckAndSetInventoryBtnState()
	{
	}

	private void CheckAndSetStorageBinBtnState()
	{
	}

	private void CheckAndSetBagBtnState()
	{
	}

	private void SetBtnState(HippoCrisisDragOperationResult dragOperationResult)
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
}
