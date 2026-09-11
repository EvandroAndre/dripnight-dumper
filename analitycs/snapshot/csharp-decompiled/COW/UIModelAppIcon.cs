using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelAppIcon : UIBaseModel
{
	private List<AppIconRegionDesc> m_AppIconDescs;

	private uint _AppIconDelayCallId;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessAppIconDescs(List<AppIconRegionDesc> AppIconDescs)
	{
	}

	public void ChangeAppIconImmediately(string icon, Action callBack = null)
	{
	}

	public void RecoverAppIconImmediately(Action callBack)
	{
	}

	public AppIconRegionDesc GetCurrentTimingAppIconDesc()
	{
		return null;
	}

	public string GetNowConfigAppIcon()
	{
		return null;
	}

	private AppIconRegionDesc GetNextConfigAppIconDesc()
	{
		return null;
	}

	public bool CheckAppIconTheSame()
	{
		return false;
	}

	public string GetCurrentOrToBeChangeAppIcon()
	{
		return null;
	}

	public void StartRecoverIconDelayCall()
	{
	}

	public void StartChangeAppIconAt()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
