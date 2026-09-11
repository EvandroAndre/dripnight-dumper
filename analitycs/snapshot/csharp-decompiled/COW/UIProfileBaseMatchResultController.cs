using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIProfileBaseMatchResultController : UIPopupWindowController
{
	protected bool HideGradeInfo;

	protected EMatchResultPageType m_PageType;

	private List<int> m_InfoTypeList;

	private List<int> m_InfoTypeListData;

	protected List<int> InfoTypeList => null;

	protected List<int> InfoTypeListData => null;

	public List<int> GetCurrentInfoTypeList()
	{
		return null;
	}

	protected virtual int[] GetInfoTypes()
	{
		return null;
	}

	protected virtual int[] GetInfoTypesData()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void OnChangePageType()
	{
	}

	protected virtual void UpdateInfoTitles()
	{
	}

	protected void UpdateInfoTitle(UILabel infoTxt, int index)
	{
	}

	protected void UpdateInfoTitle(UISprite infoSprite, int index)
	{
	}

	public static string SetMatchResultPlayerInfoString(UISprite sprite, EMatchResultPlayerInfoType type)
	{
		return null;
	}

	public static string SetMatchResultPlayerInfoString(UILabel label, EMatchResultPlayerInfoType type)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
