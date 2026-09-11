using System.Collections.Generic;
using tcp;

namespace COW;

public class AutoTaskRecieveGift : AutoPopupTask
{
	private List<ReceiveGiftNTF> m_ReceiveGiftNtfList;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	private void ShowGetGiftNotify()
	{
	}
}
