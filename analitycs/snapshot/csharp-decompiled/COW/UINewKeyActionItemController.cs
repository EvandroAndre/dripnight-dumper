using GCommon;
using UnityEngine;

namespace COW;

public class UINewKeyActionItemController : UIBaseController
{
	private UINewKeyActionItemView m_View;

	public bool EnableModify;

	public string ActionName;

	public string KeyName;

	public KeyCode KeyCodeOnUI;

	public UIButton KeyCodeButton;

	public int ItemKeyActionType;

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

	public void SetViewData(KeyActionSettingData setData)
	{
	}

	public void SetSelectState(bool hasSelected)
	{
	}

	public void SetKeyCode(KeyCode keyCode)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
