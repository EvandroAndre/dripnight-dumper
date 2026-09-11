using GCommon;
using proto;

namespace COW;

public class UINinthSYSLobbyEntranceController : UIBigEventLobbyEntranceBaseController, IUIModelDataChangeObserver
{
	private UIModelNinthSYS m_ModelNinthSYS;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public override uint GetTipTypeValue()
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnEnterProcessState()
	{
	}

	protected override void LogClick()
	{
	}

	protected override bool ShowV2GiftIcon()
	{
		return false;
	}

	protected override bool ShowV2RedPoint()
	{
		return false;
	}

	public override uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	protected override void PlayLobbyOpenSound()
	{
	}

	protected override void OnLobbyOpenAnimationFinished()
	{
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public uint _003C_003EiFixBaseProxy_GetTipTypeValue()
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnEnterProcessState()
	{
	}

	public void _003C_003EiFixBaseProxy_LogClick()
	{
	}

	public bool _003C_003EiFixBaseProxy_ShowV2GiftIcon()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ShowV2RedPoint()
	{
		return false;
	}

	public uint _003C_003EiFixBaseProxy_GetInterestedPropID(UIBaseModel P0)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnDataChanged(UIBaseModel P0, uint P1, object[] P2)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayLobbyOpenSound()
	{
	}

	public void _003C_003EiFixBaseProxy_OnLobbyOpenAnimationFinished()
	{
	}
}
