using System;
using GCommon;

namespace COW;

internal class UIHudSuperEmoteController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__11_1;

		internal void _003COnPlayBtnClick_003Eb__11_1()
		{
		}
	}

	private UIHudSuperEmoteView m_View;

	private uint m_SuperEmoteId;

	private VisualInstanceHolder m_UIFXHolder;

	private bool m_UIFXHolderStart;

	public const uint VISIBILITY_STATE_DancePoolAreaAction = 1073741824u;

	public const uint VISIBILITY_STATE_FollowEmote = 536870912u;

	private bool HideForTrigger;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetUIView(uint superEmoteId)
	{
	}

	private void OnPlayBtnClick()
	{
	}

	private void OnEnterVehicleTrigger(object[] param)
	{
	}

	private void OnExitTrigger()
	{
	}

	private void OnEnterTrigger(int param1, int param2)
	{
	}

	private void RefreshFollowEmoteVisibility()
	{
	}

	private void Update()
	{
	}

	private VisualInstanceHolder EnsureVisualInstanceHolder()
	{
		return null;
	}

	private void TryReleasePreviousHolder()
	{
	}

	private void _003COnPlayBtnClick_003Eb__11_0(bool _loadSuccess)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
