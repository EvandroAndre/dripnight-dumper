using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelPreviewWebShow : UIBaseModel
{
	private Dictionary<uint, PreviewWebDesc> m_PreviewWebDescDic;

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void ProcessCSGetPreviewWebDescRes(CSGetPreviewWebDescRes res)
	{
	}

	public bool NeedShowGuide(uint itemID)
	{
		return false;
	}

	public PreviewWebDesc GetShowDescByID(uint itemID)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
