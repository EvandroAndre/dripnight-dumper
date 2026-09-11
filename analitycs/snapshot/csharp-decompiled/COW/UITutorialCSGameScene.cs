using System;

namespace COW;

internal class UITutorialCSGameScene : UICSGameScene
{
	private UIHudTutorialMainTaskGuideController m_TutorialMainTaskCtrl;

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	private void OnShowTutorialMainTaskShow(object[] data)
	{
	}

	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public new Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
