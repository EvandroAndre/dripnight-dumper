using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIClanTagController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public uint id;

		internal bool _003COnTagSelected_003Eb__0(ClanTagData item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public uint id;

		internal bool _003COnTagSelected_003Eb__1(ClanTagData item)
		{
			return false;
		}
	}

	private UIClanTagView m_View;

	private Dictionary<uint, List<ClanTagData>> m_DictTypeToData;

	private Dictionary<uint, UIClanTagItemController> m_DictSingleSelectTag;

	private Dictionary<uint, UIClanMainTagItemController> m_DictMainTag;

	private Dictionary<uint, UIClanTagItemController> m_DictMultiSelectTag;

	private List<ClanTagData> m_CurrentSelectTagDataList;

	private UITipsNormalController m_TipsCtrl;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(List<uint> tagIdList)
	{
	}

	private void InitEvent()
	{
	}

	private void InitData()
	{
	}

	private void InitView()
	{
	}

	private void SetClanMainTagTips()
	{
	}

	private void OnTagSelected(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
