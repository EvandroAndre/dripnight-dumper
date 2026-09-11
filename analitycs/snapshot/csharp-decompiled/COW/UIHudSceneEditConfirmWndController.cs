using System;
using COW.GamePlay;
using GCommon;
using message;
using proto;

namespace COW;

public class UIHudSceneEditConfirmWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UIHudSceneEditConfirmWndController _003C_003E4__this;

		public uint slotId;

		internal void _003COnConfirmSave_003Eb__0(bool result)
		{
		}
	}

	private UIHudSceneEditConfirmWndView m_View;

	private SceneEditAgent agent;

	private Action fnApplyCallback;

	private Action fnCancelCallback;

	private HNDHJGJILHC m_CurrentGame;

	private ESceneEditConfrmWndType m_WndType;

	private UIModelSceneEdit m_ModelSceneEdit;

	private EWorkshop.UnlockSlotCostType m_CostType;

	private uint m_CostCnt;

	private bool m_IsShareGen;

	private EWorkshop.SlotType m_SlotType;

	private uint m_SlotId;

	private NIKKALKPIBO m_GameMode;

	private bool m_exportingData;

	private IBILCDHHNHM m_EntityAttributeItem;

	private int m_EntityAttributeItemIndex;

	private SceneEditAgent Agent => null;

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

	public void SetWndType(ESceneEditConfrmWndType type, object[] args)
	{
	}

	private void UpdateLocText(string titleKey, string mainKey, string warnKey, string btnConfirmKey, string btnCancelKey)
	{
	}

	private void ProcessOnUnlockSlot()
	{
	}

	private void OnClickCancelBtn()
	{
	}

	private void OnClickApplyBtn()
	{
	}

	private void OnConfirmDelAttribute()
	{
	}

	private void OnConfirmSave()
	{
	}

	private void OnConfirmNotSave()
	{
	}

	private void OnConfirmApply()
	{
	}

	private void OnConfirmUpload()
	{
	}

	private void OnConfirmUnlockSlot()
	{
	}

	private void OnConfirmShare()
	{
	}

	private void OnConfirmDel()
	{
	}

	private void OnConfirmCleanScene()
	{
	}

	private void OnCloseWnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
