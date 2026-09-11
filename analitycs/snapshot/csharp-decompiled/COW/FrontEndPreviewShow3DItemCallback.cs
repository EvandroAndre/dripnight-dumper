using System;

namespace COW;

public class FrontEndPreviewShow3DItemCallback
{
	private uint m_Ticket;

	public Action Callback;

	private bool m_HasSetTicket;

	public uint Ticket
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public FrontEndPreviewShow3DItemCallback(Action c)
	{
	}

	public void Invoke()
	{
	}
}
