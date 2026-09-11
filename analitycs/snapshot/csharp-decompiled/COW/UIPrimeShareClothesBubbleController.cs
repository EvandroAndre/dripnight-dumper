using GCommon;
using tcp;

namespace COW;

public class UIPrimeShareClothesBubbleController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public GEventSetShareNtf ntfData;

		internal bool _003COnOfferWaitAccept_003Eb__0(GroupMemberInfo teammate)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public GEventSetShareNtf ntfData;

		internal bool _003COnApplyWaitApprove_003Eb__0(GroupMemberInfo teammate)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public GEventSetShareNtf ntfData;

		internal bool _003COnThanks_003Eb__0(GroupMemberInfo teammate)
		{
			return false;
		}
	}

	private EPrimeShareClothesBubbleState m_State;

	private UIPrimeShareClothesBubbleView m_View;

	private GEventSetShareNtf m_NtfData;

	private GroupMemberInfo m_RequesterMemberInfo;

	private UIModelPrime m_ModelPrime;

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

	private void SetEventDelegate()
	{
	}

	public void SetBubbleState(GroupMemberInfo requesterMemberInfo, GEventSetShareNtf ntfData)
	{
	}

	public void HideWhenTimeOut()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void HideAndStopEmote()
	{
	}

	public uint GetSetShareID()
	{
		return 0u;
	}

	private void StopEmoteAndClear()
	{
	}

	private void CheckAndHide(uint setShareID)
	{
	}

	private void InitView()
	{
	}

	private void OnRequestingShare()
	{
	}

	private void OnActivelySharing()
	{
	}

	private void OnOfferWaitAccept(GEventSetShareNtf ntfData)
	{
	}

	private void OnApplyWaitApprove(GEventSetShareNtf ntfData)
	{
	}

	private void OnThanks(GEventSetShareNtf ntfData)
	{
	}

	private void OnButtonActivelySharingAcceptClick()
	{
	}

	private void OnButtonRequestingShareAcceptClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
