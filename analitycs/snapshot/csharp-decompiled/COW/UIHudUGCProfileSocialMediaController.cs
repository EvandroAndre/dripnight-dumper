using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIHudUGCProfileSocialMediaController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public int index;

		public UIHudUGCProfileSocialMediaController _003C_003E4__this;

		internal void _003CCreateSocialMediaItems_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UIHudUGCProfileSocialMediaController _003C_003E4__this;

		public GalleryShow.SocialMediaType targetType;

		internal void _003COnConfirmBtnClick_003Eb__0(bool success)
		{
		}
	}

	private UIHudUGCProfileSocialMediaView m_View;

	private UIModelProfileCustom m_ModelProfileCustom;

	private UIModelSceneEdit m_ModelSceneEdit;

	private List<UIProfileCustomCollectionSocialMediaItemController> m_SocialMediaItems;

	private List<GalleryShow.SocialMediaType> m_AvailableTypes;

	private int m_SelectedIndex;

	private GalleryShow.SocialMediaType m_CurrentDisplayType;

	private GallerySocialMediaInfo m_MediaInfo;

	private Action<GalleryShow.SocialMediaType> m_OnConfirmCallback;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(GalleryShow.SocialMediaType currentDisplayType, GallerySocialMediaInfo mediaInfo, Action<GalleryShow.SocialMediaType> onConfirmCallback)
	{
	}

	private void CreateSocialMediaItems()
	{
	}

	private ProfileCustomSocialMediaData CreateUnlinkedSocialMediaData(GalleryShow.SocialMediaType type, GallerySocialMediaInfo socialMediaInfo)
	{
		return null;
	}

	private void OnItemClick(int index)
	{
	}

	private void SelectItem(int index)
	{
	}

	private void RefreshConfirmBtn()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnCancelBtnClick()
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
