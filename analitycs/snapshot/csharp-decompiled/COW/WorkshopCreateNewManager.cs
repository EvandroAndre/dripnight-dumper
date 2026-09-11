using System.Collections.Generic;
using GCommon;

namespace COW;

public class WorkshopCreateNewManager : SingletonModule<WorkshopCreateNewManager>
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public uint id;

		internal bool _003CGetDataTemplateID_003Eb__0(WorkshopCreateNewConfigData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public int id;

		internal bool _003CGetDataByTemplateID_003Eb__0(WorkshopCreateNewConfigData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public int id;

		internal bool _003CGetDataByMapID_003Eb__0(WorkshopCreateNewConfigData x)
		{
			return false;
		}
	}

	private List<WorkshopCreateNewConfigData> m_ModeList;

	private List<WorkshopCreateNewConfigData> m_MapList;

	private List<string> m_NewModeList;

	private List<string> m_NewMapList;

	private uint m_DefaultMode;

	private uint m_DefaultMap;

	private bool m_CustomTemplateActivated;

	protected override void OnInit()
	{
	}

	public List<WorkshopCreateNewConfigData> GetModeList()
	{
		return null;
	}

	public List<WorkshopCreateNewConfigData> GetMapList()
	{
		return null;
	}

	public uint GetDataTemplateID(uint id)
	{
		return 0u;
	}

	public WorkshopCreateNewConfigData GetDataByTemplateID(int id)
	{
		return null;
	}

	public WorkshopCreateNewConfigData GetDataByMapID(int id)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
