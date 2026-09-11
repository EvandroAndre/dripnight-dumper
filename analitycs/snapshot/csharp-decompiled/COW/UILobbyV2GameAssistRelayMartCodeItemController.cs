using GCommon;

namespace COW;

public class UILobbyV2GameAssistRelayMartCodeItemController : UILobbyV2GameAssistNormalItemController, IUIModelDataChangeObserver
{
	private UILobbyV2GameAssistRelayMartCodeItemView m_View;

	private AssistRelayMartCodeInfo m_Info;

	private UIModelGameAssistantIntroduction m_ModelGameAssist;

	private UIModelRelayMart m_ModelRelayMart;

	private ulong m_LastBtnClickTime;

	private bool m_HasClickCopyAndUseBtn;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void SetViewData(object data, int index)
	{
	}

	protected override void SetRead()
	{
	}

	private void RefreshCodeView()
	{
	}

	private void OnCopyAndUseBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetRead()
	{
	}
}
