using System;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditCameraHeightController : UIHudUGCTutorialRestrictionBaseController
{
	private enum EState
	{
		Original,
		ItemPanel,
		ItemGenPanel
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__20_0;

		internal void _003CTutorialSlider_003Eb__20_0()
		{
		}
	}

	private const uint VISIBILITY_STATE_TUTORIAL_RESTRICTION = 1073741824u;

	private UIHudSceneEditCameraHeightView m_View;

	private SceneEditAgent m_Agent;

	private uint m_DelayCall;

	private bool m_HasChanged;

	private bool m_ItemPanelPopped;

	public SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void Update()
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void Show()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void UpdateHeightSlider()
	{
	}

	private void OnHeightSliderChange()
	{
	}

	private void UpdateCamSlider(object[] data)
	{
	}

	private void OnItemPanelChanged(object[] data)
	{
	}

	private void OnHandleSliderDragFinish()
	{
	}

	private void TutorialSlider(object[] data)
	{
	}

	private void OnItemGenPanelAppear()
	{
	}

	private void OnItemGenPanelDispear(object[] data)
	{
	}

	private void SetViewState(EState state)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
