using System;
using GCommon;

namespace COW;

internal class UIHudSceneEditSkyBoxAttributeToggleController : UIBaseController
{
	private UIHudSceneEditSkyBoxAttributeToggleView m_View;

	private Action<string> m_ValueChangeCallback;

	private string m_CurValue;

	private string m_TipKey;

	private string CurValue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitShowData(string title, string curValue)
	{
	}

	public void RegisetrValueChangeCallback(Action<string> callBack)
	{
	}

	private void OnToggleSwitchClick()
	{
	}

	private void OnClickHintButton()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
