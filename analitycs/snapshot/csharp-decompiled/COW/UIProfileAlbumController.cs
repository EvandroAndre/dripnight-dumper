using System;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileAlbumController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public AlbumPhotoInfo info;

		internal bool _003CIsAlbumPhotoInfoInDeleteList_003Eb__0(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIProfileAlbumController _003C_003E4__this;

		public AlbumPhotoInfo info;

		public Predicate<AlbumPhotoInfo> _003C_003E9__1;

		internal void _003COnPhotoBtnClick_003Eb__0(bool success, MediaMgr.IAlbumImageTexture img, string failTipStr)
		{
		}

		internal bool _003COnPhotoBtnClick_003Eb__1(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public long timeTick;

		internal bool _003COnLeftArrowBtnClick_003Eb__0(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public long timeTick;

		internal bool _003COnRightArrowBtnClick_003Eb__0(AlbumPhotoInfo p)
		{
			return false;
		}
	}

	private bool IsLoadBytesToTexture;

	private List<AlbumPhotoInfo> m_DeleteAlbumPhotoInfos;

	public bool IsDeleteState;

	private List<UIProfileAlbumItemController> m_AlbumItemControllers;

	private List<AlbumPhotoInfo> m_AlbumPhotoInfos;

	private List<AlbumPhotoInfo> m_FilteredAlbumPhotoInfos;

	private UIModelTakePhoto m_Model;

	private UIProfileAlbumView m_View;

	private bool m_ShowHighlightPhotos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	void IEasyList.CloseItemController(UIEasyListItemController itemController)
	{
	}

	UIEasyListItemController IEasyList.OpenItemController(Transform parent)
	{
		return null;
	}

	public void RefreshUI()
	{
	}

	private void RefreshUIInternal()
	{
	}

	private void OnTrashBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnDeleteBtnClick()
	{
	}

	private void OnClickTipsBtn()
	{
	}

	private void OnNormalToggleBtnClick()
	{
	}

	private void OnHighlightToggleBtnClick()
	{
	}

	private void FilterAlbumPhotos()
	{
	}

	public bool IsAlbumPhotoInfoInDeleteList(AlbumPhotoInfo info)
	{
		return false;
	}

	private void RefreshDeleteView()
	{
	}

	public void OnSelectBtnClick(AlbumPhotoInfo info)
	{
	}

	public void OnPhotoBtnClick(AlbumPhotoInfo info)
	{
	}

	private void ShowUGCPreviewWindow(ShareImageData info, int curIdx, AlbumPhotoInfo albumPhotoInfo)
	{
	}

	private void RefreshMemory()
	{
	}

	public void OnLeftArrowBtnClick(long timeTick)
	{
	}

	public void OnRightArrowBtnClick(long timeTick)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnUIDestory()
	{
	}

	private void _003CRefreshUI_003Eb__13_0(MediaMgr.MediaType media, MediaMgr.MediaAccessType access, MediaMgr.MediaAuthStatus auth, string error)
	{
	}

	private void _003COnDeleteBtnClick_003Eb__17_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
