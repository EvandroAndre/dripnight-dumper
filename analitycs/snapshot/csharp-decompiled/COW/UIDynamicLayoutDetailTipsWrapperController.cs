using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDynamicLayoutDetailTipsWrapperController : UIPopupWindowController
{
	private UIRoot m_CachedRootInCurrentScene;

	private UIDynamicLayoutDetailTipsWrapperView m_View;

	private IDynamicLayoutDetailTipsContent m_Content;

	private UIRoot RootInCurrentScene => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	private static void ContentTypeCheck(Type contentControllerType)
	{
	}

	private void OpenContentController(Type contentControllerType)
	{
	}

	private void PopulateContent(object contentViewData)
	{
	}

	private void RebuildLayout()
	{
	}

	private void SetTweenToEnd()
	{
	}

	private void PlayTween()
	{
	}

	private void ResetPosition(Vector3 targetWorldPosition, bool screenClippingCheck)
	{
	}

	private void OnMaskClicked()
	{
	}

	private void AddEventDelegates()
	{
	}

	public void LoadWrappedContent(Type contentControllerType)
	{
	}

	public void LoadWrappedContent<T>() where T : UIBaseController, IDynamicLayoutDetailTipsContent
	{
	}

	public void Populate(Vector3 targetWorldPosition, object contentViewData, bool screenClippingCheck)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
