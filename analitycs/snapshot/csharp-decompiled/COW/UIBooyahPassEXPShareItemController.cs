using GCommon;

namespace COW;

public class UIBooyahPassEXPShareItemController : UIEasyListItemController
{
	private UIModelBooyahPass m_ModelBooyahPass;

	private UIBooyahPassEXPShareItemView m_View;

	private BooyahPassShareExpData m_ItemData;

	private UIBaseProfileInfoController m_CtrlProfile;

	private static string RECEIVE_TIME_MAX_TEXT;

	private const uint RECEIVE_MAX_TIMES = 99u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnCanSendExp()
	{
	}

	private void OnCanNotSendExp()
	{
	}

	private void OnClaimxp()
	{
	}

	private void PrepareCtrl()
	{
	}

	private void SetLevel()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void AddEventDelegate()
	{
	}

	public UIWidget GetGuide1Widget()
	{
		return null;
	}

	public UIWidget GetGuide2Widget()
	{
		return null;
	}

	public void ShowClaimVfx(bool flag)
	{
	}

	public void ShowSendVfx(bool flag)
	{
	}

	public float GetClaimVfxTime()
	{
		return 0f;
	}

	public float GetSendVfxTime()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
