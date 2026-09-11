using COW.OpSysExt;
using GCommon;
using UnityEngine;

namespace COW;

public class UIEditableImageController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass62_0
	{
		public AlbumPhotoInfo albumPhotoInfo;

		public UIEditableImageController _003C_003E4__this;

		internal void _003COnCapturedPhotoSavedToAlbum_003Eb__0(bool success, MediaMgr.IAlbumImageTexture img, string failTipStr)
		{
		}
	}

	private UIEditableImageView m_View;

	private bool isSelect;

	private UIEditableImageDropItem moveDropItem;

	private UIEditableImageDropItem rotatingDropItem;

	private UIEditableImageDropItem scalingDropItem;

	private GameObject editContainer;

	private GameObject rotatingBtnContainer;

	private GameObject scalingBtnContainer;

	private GameObject deleteBtnContainer;

	private GameObject copyBtnContainer;

	private GameObject editBtnContainer;

	private GameObject borderIcon;

	private Transform targetTransform;

	private UITexture targetTexture;

	private TweenAlpha twinkleAnim;

	private UIButton selectBtn;

	private UIButton copyBtn;

	private UIButton deleteBtn;

	private UIButton editBtn;

	private UISprite line01;

	private UISprite line02;

	private UISprite line03;

	private UISprite line04;

	private Texture curTexture;

	private Texture curDisplayTexture;

	private bool curIsVertical;

	private Bounds? curDragBounds;

	private AlbumPhotoInfo curPhotoInfo;

	private const float BorderMargin = 8f;

	private Vector3 m_EditBtnContainerInitialLocalPos;

	private float m_EditBtnContainerPrefabHalfW;

	private bool m_HasCachedEditBtnContainerInitial;

	public int CurHashCode;

	private bool canDrag;

	public Transform TargetTransformRef => null;

	public bool IsVertical => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void PlayTwinkleAnim()
	{
	}

	public void SetSelectState(bool select, bool isManualSelect = false)
	{
	}

	public void SetViewData(UIWidget widgetBound, Texture texture, bool isVertical = false)
	{
	}

	public void SetAlbumPhotoInfo(AlbumPhotoInfo photoInfo)
	{
	}

	public AlbumPhotoInfo GetAlbumPhotoInfo()
	{
		return null;
	}

	private void InitDropItems(UIWidget widgetBound)
	{
	}

	private void SetTextureData(Texture texture, bool isVertical)
	{
	}

	private void DestroyCurrentTexture()
	{
	}

	private static Texture2D RotateTexture90(Texture2D source)
	{
		return null;
	}

	public void DisableResetWhenDrop()
	{
	}

	public void SetAllDropItemDragBounds(Bounds bounds)
	{
	}

	public void SetDepth(int depth)
	{
	}

	public int GetDepth()
	{
		return 0;
	}

	public void SetImageTransform(Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	private void SyncDropItemTransform()
	{
	}

	private void OnScaleDragMove()
	{
	}

	private void OnDragMove()
	{
	}

	private void OnCopyBtnClick()
	{
	}

	private void OnDeleteBtnClick()
	{
	}

	private void OnEditBtnClick()
	{
	}

	private void OnCapturedPhotoSavedToAlbum(AlbumPhotoInfo albumPhotoInfo)
	{
	}

	private static Texture2D DuplicateTexture(Texture2D source)
	{
		return null;
	}

	private void _003COnUIInit_003Eb__35_0()
	{
	}

	private void _003CInitDropItems_003Eb__43_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
