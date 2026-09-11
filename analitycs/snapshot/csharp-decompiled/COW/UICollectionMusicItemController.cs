using GCommon;

namespace COW;

public class UICollectionMusicItemController : UIEasyListItemController, IUINewVaultLovableItem
{
	private UICollectionMusicItemView m_View;

	private uint m_ItemIconGrey;

	private bool m_CollectionABReady;

	private MusicData m_MusicData;

	private UINewVaultItemViewData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetCornerIconTag()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public void RefreshEquipState()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void RefreshIsLoved(bool playVFX = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
