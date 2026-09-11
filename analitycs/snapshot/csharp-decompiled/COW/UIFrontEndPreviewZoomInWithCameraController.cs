using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewZoomInWithCameraController : UIPopupWindowController
{
	private UIFrontEndPreviewZoomInWithCameraView m_View;

	private GameObject m_cameraObj;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private Action m_CallBack;

	private bool m_IsCreated;

	private Vector3 m_LastPosition;

	private Quaternion m_LastRotation;

	private Transform m_Transform;

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

	public void ShowCamera(ResourceID resId)
	{
	}

	public void SetAvatarPosition(UIMaleAvatar avatar, Vector3 position, Quaternion rotation)
	{
	}

	public void SetCameraPosition(Vector3 position)
	{
	}

	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnZoomCancel(object[] data)
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

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
