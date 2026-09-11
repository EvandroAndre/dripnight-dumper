using GCommon;
using proto;

namespace COW;

public class UIBigEventVideoRulesWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UIBigEventVideoRulesWndController _003C_003E4__this;

		public ulong startTime;

		internal void _003COnWebVideoBtn_003Eb__0()
		{
		}
	}

	private UIBigEventVideoRulesWndView m_View;

	private UIModelBigEvent m_ModelBigEvent;

	protected override void OnUIInit()
	{
	}

	public virtual ELimitedEvent.EventID GetEventID()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public virtual UIModelBigEvent.EBigEventEntranceID GetEntranceID()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override string CustomTitle()
	{
		return null;
	}

	public void SetData(string ruleKey, string cdn)
	{
	}

	protected virtual void OnVideoClose(ulong startTime)
	{
	}

	private void OnWebVideoBtn()
	{
	}

	protected bool CheckEntranceState(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}
}
