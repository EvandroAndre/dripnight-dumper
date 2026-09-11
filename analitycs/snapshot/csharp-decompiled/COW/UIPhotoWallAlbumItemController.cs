using GCommon;
using UnityEngine;

namespace COW;

public class UIPhotoWallAlbumItemController : UIEasyListItemController
{
	private UIPhotoWallAlbumItemView m_View;

	private UIModelTakePhoto m_Model;

	private AlbumPhotoInfo m_AlbumPhotoInfo;

	private int m_TexInitialWidth;

	private int m_TexInitialHeight;

	private bool m_IsDragging;

	private bool m_IgnoreAlbumDragThisGesture;

	public AlbumPhotoInfo AlbumPhotoInfo => null;

	public UIPhotoWallWndController PhotoWallParent => null;

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

	private void OnItemDragStart(GameObject go)
	{
	}

	private void OnItemDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnItemDragEnd(GameObject go)
	{
	}

	private void OnItemClick(GameObject go)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
