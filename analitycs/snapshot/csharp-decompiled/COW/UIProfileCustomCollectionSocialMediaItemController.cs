using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileCustomCollectionSocialMediaItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public UICommonTinyMsgBoxController ctrl;

		public UIProfileCustomCollectionSocialMediaItemController _003C_003E4__this;

		internal void _003CTryToBindSocialMedia_003Eb__0()
		{
		}

		internal void _003CTryToBindSocialMedia_003Eb__1()
		{
		}

		internal void _003CTryToBindSocialMedia_003Eb__2()
		{
		}
	}

	private UIProfileCustomCollectionSocialMediaItemView m_View;

	private UIModelProfileCustom m_ModelProfileCustom;

	private ProfileCustomSocialMediaData m_SocialMediaData;

	private bool m_EnableUGCSetting;

	private bool IsInUGCProfile => false;

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

	public override void SetViewData(ProfileCustomModuleData data)
	{
	}

	private void UpdateSelfSocialMediaInfo()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateUIForSelf()
	{
	}

	private void UpdateUIForOthers()
	{
	}

	private void ShowAvatarIcon()
	{
	}

	private bool CheckIsKOL()
	{
		return false;
	}

	private void OnGotoButtonClick()
	{
	}

	private void OnUnlinkedButtonClick()
	{
	}

	private void OnGoLinkButtonClick()
	{
	}

	private void TryToBindSocialMedia()
	{
	}

	private string GetSocialMediaIconSpriteName(GalleryShow.SocialMediaType type)
	{
		return null;
	}

	protected override ProfileCustomDragDropItem GetDragDropItem()
	{
		return null;
	}

	public override GameObject GetIcon()
	{
		return null;
	}

	protected override void CaclulateItemOffset()
	{
	}

	private void OnUIUpdate(int dataSource, int moduleId)
	{
	}

	private void OnItemClick(object[] args)
	{
	}

	private string GetPlatformKey(GalleryShow.SocialMediaType mediaType)
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetEnableUGCSetting(bool enable)
	{
	}

	public void SetUGCShowVisible(bool visible)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public ProfileCustomSocialMediaData GetSocialMediaData()
	{
		return null;
	}

	public UIButton GetButton()
	{
		return null;
	}

	public void SetDragEnabled(bool enabled)
	{
	}

	private void _003COnUnlinkedButtonClick_003Eb__17_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(ProfileCustomModuleData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_CaclulateItemOffset()
	{
	}
}
