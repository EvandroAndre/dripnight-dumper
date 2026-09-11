using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCLocalDatabase : IUGCLocalDatabase
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public GetUGCDatabaseNormalDataRequest req;

		internal bool _003CGetNormalTableData_003Eb__0(BBEGMKEHHFI.KLHEMBJCOPE x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public SetUGCDatabaseNormalDataRequest req;

		internal bool _003CSetNormalTableData_003Eb__0(BBEGMKEHHFI.KLHEMBJCOPE x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public DeleteUGCDatabaseNormalDataRequest req;

		internal bool _003CDeleteNormalTableData_003Eb__0(BBEGMKEHHFI.KLHEMBJCOPE x)
		{
			return false;
		}
	}

	private readonly UGCRuntime m_UGCRuntime;

	private readonly string m_WorkshopCode;

	private Dictionary<string, BBEGMKEHHFI> m_NormalTables;

	private HashSet<string> m_DirtyMap;

	public UGCLocalDatabase(UGCRuntime ugcRuntime, string workshopCode)
	{
	}

	public void Close()
	{
	}

	public BBEGMKEHHFI.KLHEMBJCOPE GetNormalTableData(GetUGCDatabaseNormalDataRequest req)
	{
		return null;
	}

	public BBEGMKEHHFI.KLHEMBJCOPE SetNormalTableData(SetUGCDatabaseNormalDataRequest req)
	{
		return null;
	}

	public BBEGMKEHHFI.KLHEMBJCOPE DeleteNormalTableData(DeleteUGCDatabaseNormalDataRequest req)
	{
		return null;
	}

	public void Commit()
	{
	}

	private BBEGMKEHHFI GetNormalTable(string tableName, bool createIfMissing = false)
	{
		return null;
	}

	private bool LoadLocalTable(string tableName)
	{
		return false;
	}

	private bool SaveLocalTable(string tableName)
	{
		return false;
	}

	private string GetLocalFilePath(string workshopCode, string tableName)
	{
		return null;
	}
}
