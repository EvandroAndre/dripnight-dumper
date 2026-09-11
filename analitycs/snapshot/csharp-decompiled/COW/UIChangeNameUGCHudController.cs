using System;
using GCommon;

namespace COW;

public class UIChangeNameUGCHudController : UIChangeNameBaseController
{
	private int m_CharLimit;

	private Action<string> m_ChangeCallback;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void Awake()
	{
	}

	protected override void RefreshBtnView(bool isShowEnable)
	{
	}

	protected override bool CheckNicknameValid(string newName)
	{
		return false;
	}

	private void InitView()
	{
	}

	public void RefreshViewData(string curName, Action<string> changeCallback, int charLimit)
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshBtnView(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckNicknameValid(string P0)
	{
		return false;
	}
}
