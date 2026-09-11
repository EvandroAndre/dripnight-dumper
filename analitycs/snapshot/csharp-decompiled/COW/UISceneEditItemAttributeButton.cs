using System;
using GCommon;

namespace COW;

internal class UISceneEditItemAttributeButton : UISceneEditItemAttributeControllerBase
{
	private UISceneEditItemAttributeButtonView m_View;

	private string m_CurValue;

	private string m_TipKey;

	private Action<int> m_ButtonCallBack;

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

	public void InitShowData(ItemEditAttributeUIDataButton data)
	{
	}

	private void OnClickHintButton()
	{
	}

	private void OnClickFunctionButton()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
