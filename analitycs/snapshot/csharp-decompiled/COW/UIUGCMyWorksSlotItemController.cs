using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using proto;

namespace COW;

public class UIUGCMyWorksSlotItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	public enum ESpecialSlot
	{
		None,
		CreatorLevel
	}

	private sealed class _003CWaitForShareAnim_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCMyWorksSlotItemController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitForShareAnim_003Ed__31(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public EUGCSlotDisplayType DisplayType;

	private UIUGCMyWorksSlotItemView m_View;

	private SceneEditSlotInfo m_SlotInfo;

	private EWorkshop.SlotType m_SlotType;

	private EWorkshop.SlotState m_SlotState;

	private UIModelSceneEdit m_Model;

	private UIModelUGCMyWorks m_ModelUGCMyWorks;

	private UIModelOptionalDownload m_ModelDownload;

	private float m_RedPointPadding;

	private EUGCSlotDisplayType m_ListDisplayType;

	private ESpecialSlot m_SpecialSlot;

	private uint m_CreatorLevel;

	private int m_CreatorLevelUnlockDelta;

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

	public void SetDisplayContext(EUGCSlotDisplayType listDisplayType, uint creatorLevel, int creatorLevelUnlockDelta)
	{
	}

	private void OnBtnClick()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshDraftDisplay()
	{
	}

	private void RefreshPublishedDisplay()
	{
	}

	public void RefreshRedPoint()
	{
	}

	public void PlayUploadAnim()
	{
	}

	public void PlayDownloadAnim()
	{
	}

	private void ProcessUnlockContent()
	{
	}

	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	private bool HasLocalCoverEdited()
	{
		return false;
	}

	private IEnumerator WaitForShareAnim()
	{
		return null;
	}

	private void OnUGCResDownloaderClick(UGCSimpleDownloadTask resDownloadTask, bool autoDownload = false)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIInit_003Eb__15_0()
	{
	}

	private void _003COnUIInit_003Eb__15_1()
	{
	}

	private void _003COnItemBtnClick_003Eb__19_0()
	{
	}

	private void _003CProcessUnlockContent_003Eb__28_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
