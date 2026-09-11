using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponZoomInController : UIPopupWindowController
{
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private UIFrontEndPreviewWeaponZoomInView m_View;

	private GameObject m_ItemCameraGo;

	private Camera m_ItemCamera;

	private GameObject m_ZoomItem;

	private Action m_CallBack;

	private bool m_IsCreated;

	private bool m_CanRotated;

	private const float m_RotateRate = 0.5f;

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

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private void SetItemCamState(bool enabled)
	{
	}

	private void Rotate3DModel()
	{
	}

	private void Update()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnZoomCancel(object[] data)
	{
	}

	private void OnZoomClose(object[] data)
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
