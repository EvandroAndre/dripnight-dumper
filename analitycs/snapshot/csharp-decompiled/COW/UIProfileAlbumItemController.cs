using GCommon;

namespace COW;

public class UIProfileAlbumItemController : UIEasyListItemController
{
	private UIModelTakePhoto m_Model;

	private AlbumPhotoInfo m_AlbumPhotoInfo;

	private UIProfileAlbumItemView m_View;

	private int TexInitialWidth;

	private int TexInitialHeight;

	public UIProfileAlbumController ParentAlbumController => null;

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

	private void OnPhotoBtnClick()
	{
	}

	private void OnSelectBtnClick()
	{
	}

	public void SetDeleteState(bool isDeleteState)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
