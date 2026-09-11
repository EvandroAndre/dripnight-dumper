using System;
using System.Collections.Generic;

namespace COW;

internal class UITokenGameScene : UITeamModeBaseGameScene
{
	private bool m_IntroInfoDone;

	private List<UIHudTokenComboController> m_ConboCtrls;

	public override void RegisterGameEventHandler()
	{
	}

	protected override void OnDestory()
	{
	}

	protected override void OnOpenHudInPregame()
	{
	}

	public void OnIntroInfoDone(object[] data)
	{
	}

	public void OnIntroInfoShow(object[] data)
	{
	}

	private void OnShowCombo(object[] data)
	{
	}

	public void ShowLastPointTip(string tipContent)
	{
	}

	protected override Type GetMatchResultType()
	{
		return null;
	}

	private void _003COnIntroInfoShow_003Eb__6_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}

	public Type _003C_003EiFixBaseProxy_GetMatchResultType()
	{
		return null;
	}
}
