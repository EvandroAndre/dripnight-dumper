using GCommon;

namespace COW;

public class UIHudWereWolvesVoiceEngineController : UIBaseController, IUIModelDataChangeObserver
{
	private UIHudWereWolvesVoiceEngineView m_View;

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

	protected override void OnUIOpen()
	{
	}

	private void OnToggleMic()
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	private void OnToggleSpeaker()
	{
	}

	private void OnVoiceChanged(object[] data)
	{
	}

	private void RefreshButtonState()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
