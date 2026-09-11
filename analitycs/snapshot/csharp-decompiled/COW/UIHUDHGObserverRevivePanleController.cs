using GCommon;
using message;

namespace COW;

public class UIHUDHGObserverRevivePanleController : UIBaseController
{
	private UIHUDHGObserverRevivePanleView m_View;

	private bool m_IsHelped;

	private UIModelMatch m_ModelMatch;

	private DNEKLHCPPHH m_CurReviveType;

	private bool m_IsEnough;

	private bool IsEnough
	{
		set
		{
		}
	}

	public bool IsHelped
	{
		get
		{
			return false;
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

	protected override void OnUIOpen()
	{
	}

	public void RefreshData()
	{
	}

	private void SwitchShowStyle()
	{
	}

	private void ProcessReviveBtnClick()
	{
	}

	private void TryRequesetRevive()
	{
	}

	private void TryRequesetHelpRevive()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
