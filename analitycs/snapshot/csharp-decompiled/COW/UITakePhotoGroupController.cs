using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UITakePhotoGroupController : UITakePhotoGroupBaseController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public int hashCode;

		internal bool _003CDeleteEditableBackGround_003Eb__0(UIEditableIconBaseController e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public uint id;

		internal bool _003CGetEditableBackGroundById_003Eb__0(UIEditableIconBaseController e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public PhotoDecoretonsConfigDesc photoDecoretonsConfigDesc;

		internal bool _003CCheckOneEditBackgroundIsNumLimit_003Eb__0(UIEditableIconBaseController e)
		{
			return false;
		}
	}

	private sealed class _003CSetPanelSize_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITakePhotoGroupController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetPanelSize_003Ed__6(int _003C_003E1__state)
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

	private UITakePhotoGroupView m_View;

	private UITakePhotoGroupTemplateController m_PhotoTemplateCtrl;

	private UIHudCameraOperationBtnOutInGameController m_PhotoBtnCtrl;

	private Vector2 m_StickerRandomOffset;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private IEnumerator SetPanelSize()
	{
		return null;
	}

	protected override void InitView()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override void OnSelectFriend(ulong account_id)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnSelectTemplate(GroupPhotoTemplateData templateData)
	{
	}

	public override void OnSelectBackGround(PhotoEditBackgroundData backGroundData)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnCloseBtn()
	{
	}

	protected override string GetExpandFriendAnim(bool isIn)
	{
		return null;
	}

	public override void OnExpandBtn()
	{
	}

	protected override void ShowFriendList()
	{
	}

	protected override void HideFriendList()
	{
	}

	public void ForceHideFriendList()
	{
	}

	protected virtual void CreateEditableBackGround(object[] data)
	{
	}

	protected virtual void DeleteEditableBackGround(object[] data)
	{
	}

	public UIEditableIconBaseController GetEditableBackGroundById(uint id)
	{
		return null;
	}

	private bool CheckOneEditBackgroundIsNumLimit(PhotoDecoretonsConfigDesc photoDecoretonsConfigDesc)
	{
		return false;
	}

	public bool CheckAllEditBackgroundIsNumLimit()
	{
		return false;
	}

	public void UnselectAllCurBackGround()
	{
	}

	public void SetBackGroundUnSelectBtn(bool enable)
	{
	}

	private void CheckDepthLimitAndResetDepth()
	{
	}

	private Vector3 GetWorldPosByDefaultShow(float[] defaultShowPos)
	{
		return default(Vector3);
	}

	private Vector3 GetRandomCreatePosition()
	{
		return default(Vector3);
	}

	private Vector3 TransDefaultShowPosToWorldPos(Vector2 defaultPos)
	{
		return default(Vector3);
	}

	public void RefreshBtnTable(bool isSelectEditBackground)
	{
	}

	private void ClearAllEditBackgrounds()
	{
	}

	public void ShowNotOwnedTemplateWithDefaultFemaleAvatars(GroupPhotoTemplateData templateData)
	{
	}

	public void ResetNormalOwnedPreview()
	{
	}

	public void SetEditBackgroundToMaxDepth(int hashCode)
	{
	}

	public void OnFirstSelectTemplateList()
	{
	}

	public ECGroupPhotoGoposFrom GetFrom()
	{
		return (ECGroupPhotoGoposFrom)0;
	}

	public override void OnSelectBigEventBackGround(PhotoBackGroundData backGroundData)
	{
	}

	public void RefreshPhotoBgTab()
	{
	}

	public void ShowBigEventBackGroundGoto(PhotoBackGroundData bigEventBackGroundData)
	{
	}

	public void ShowBigEventBackGroundPreview(PhotoBackGroundData bigEventBackGroundData)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelectFriend(ulong P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelectTemplate(GroupPhotoTemplateData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelectBackGround(PhotoEditBackgroundData P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnExpandBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_ShowFriendList()
	{
	}

	public void _003C_003EiFixBaseProxy_HideFriendList()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSelectBigEventBackGround(PhotoBackGroundData P0)
	{
	}
}
