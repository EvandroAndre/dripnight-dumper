using GCommon;

namespace COW;

public class UIModelGin : UIBaseModel
{
	private bool m_RequestedUserLogin;

	public bool RequestedGinToken;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public override void Init()
	{
	}

	public void RequestGinToken()
	{
	}

	public void RequestPushData(bool silence = false)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
