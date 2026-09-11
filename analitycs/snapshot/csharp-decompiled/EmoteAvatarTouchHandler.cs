using System;
using COW;
using GCommon;
using UnityEngine;

public class EmoteAvatarTouchHandler : MonoBehaviour
{
	private Camera cam;

	private UIPopupWindowController popWinCtrl;

	private Type naviType;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private float OffsetX;

	private float OffsetY;

	private Vector3 pressPos;

	private Vector3 releasePos;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private bool CheckNaviType(Type t)
	{
		return false;
	}

	private void CheckTouchAvatar()
	{
	}

	protected virtual void OnTouchAvatar()
	{
	}

	private bool IsCamAvalible(Camera cam)
	{
		return false;
	}

	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}
}
