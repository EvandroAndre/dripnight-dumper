using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudRedEnvelopeReceiveController : UIBaseController
{
	private UIHudRedEnvelopeReceiveWindowView m_View;

	private uint lastLvlObjID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ShowReceiveWindow(object[] param)
	{
	}

	private void UpdateUI(LevelRedEnvelope levelRed)
	{
	}

	private void OnRedEnvelopeReceived(object[] param)
	{
	}

	private void OnClickOpenButton()
	{
	}

	private void OnClickReceiveInfo()
	{
	}

	private void OnClickCloseButton()
	{
	}

	private void OnEventClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
