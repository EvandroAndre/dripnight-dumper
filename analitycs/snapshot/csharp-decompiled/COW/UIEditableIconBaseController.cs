using GCommon;
using UnityEngine;

namespace COW;

public class UIEditableIconBaseController : UIBaseController
{
	protected bool IsSelect;

	protected bool IsVertical;

	protected UIEditableIconDropItem MoveDropItem;

	protected UIEditableIconDropItem RotatingDropItem;

	protected UIEditableIconDropItem ScalingDropItem;

	protected GameObject EditContainer;

	protected GameObject RotatingBtnContainer;

	protected GameObject ScalingBtnContainer;

	protected GameObject DeleteBtnContainer;

	protected GameObject CopyBtnContainer;

	protected GameObject BorderIcon;

	protected Transform TargetTransform;

	protected UISprite IconSprite;

	protected UILabel DescLabel;

	protected UILabel TxtLabel;

	protected TweenAlpha TwinkleAnim;

	protected UIButton SelectBtn;

	protected UIButton CopyBtn;

	protected UIButton DeleteBtn;

	protected UISprite Line01;

	protected UISprite Line02;

	protected UISprite Line03;

	protected UISprite Line04;

	protected UIWidget TargatWidget;

	protected Transform SyncTransfrom;

	protected StickerWithResConfig CurStickerConfig;

	protected PhotoEditBackgroundData CurEditBackgroundData;

	protected UIPanel TargetPanel;

	public int CurHashCode;

	protected bool CanDrag;

	public Transform TargetTransformRef => null;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual void PlayTwinkleAnim()
	{
	}

	public virtual void SetSelectState(bool isSelect, bool isManualSelect = false)
	{
	}

	public virtual void SetViewData(UIWidget widgetBound, StickerWithResConfig stickerWithResConfig, string descLabel = null, bool isVertical = false)
	{
	}

	public virtual void SetViewData(UIWidget widgetBound, PhotoEditBackgroundData editBackgroundData, string descLabel = null, bool isVertical = false)
	{
	}

	public virtual void SetDepth(int depth)
	{
	}

	public virtual int GetDepth()
	{
		return 0;
	}

	public virtual int GetStickerID()
	{
		return 0;
	}

	public uint GetEditBackgroundID()
	{
		return 0u;
	}

	protected virtual void SyncDropItemTransform()
	{
	}

	protected virtual void OnScaleDragMove()
	{
	}

	private void OnDragMove()
	{
	}

	public void SetStickerUnSelectBtn()
	{
	}

	public void SetAllDropItemDragBounds(Bounds bounds)
	{
	}

	public void DisableResetWhenDrop()
	{
	}

	public void SetStickerTransform(Vector3 position, Quaternion rotation, Vector3 localScale)
	{
	}

	protected virtual void OnCopyBtnClick()
	{
	}

	protected virtual void OnDeleteBtnClick()
	{
	}

	public virtual void SetTimeLableColor(string colorStr)
	{
	}

	private void _003COnUIInit_003Eb__30_0()
	{
	}

	private void _003CSetViewData_003Eb__35_0()
	{
	}

	private void _003CSetViewData_003Eb__36_0()
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
