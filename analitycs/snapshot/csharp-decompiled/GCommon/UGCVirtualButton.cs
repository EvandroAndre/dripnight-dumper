namespace GCommon;

internal class UGCVirtualButton
{
	private string _003Cname_003Ek__BackingField;

	private int frameCount;

	private bool m_Pressed;

	private int m_LastPressedFrame;

	private int m_ReleasedFrame;

	private bool m_RealPressed;

	public string name
	{
		get
		{
			return _003Cname_003Ek__BackingField;
		}
		private set
		{
			_003Cname_003Ek__BackingField = value;
		}
	}

	public bool GetButton => false;

	public bool GetButtonDown => false;

	public bool GetButtonUp => false;

	public UGCVirtualButton(string name)
	{
	}

	public bool Tick()
	{
		return false;
	}

	public void Pressed()
	{
	}

	public void Released()
	{
	}
}
