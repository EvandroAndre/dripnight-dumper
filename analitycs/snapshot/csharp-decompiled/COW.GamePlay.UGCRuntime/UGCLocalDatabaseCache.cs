using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCLocalDatabaseCache : IUGCLocalDatabase
{
	protected readonly UGCRuntime m_UGCRuntime;

	protected bool m_Dirty;

	protected readonly string m_WorkshopCode;

	protected Dictionary<string, Dictionary<string, BBEGMKEHHFI.KLHEMBJCOPE>> m_NormalTableDatas;

	public UGCLocalDatabaseCache(UGCRuntime ugcRuntime, string workshopCode)
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

	public void AddOrUpdateNormalTableDataCache(string tableName, BBEGMKEHHFI.KLHEMBJCOPE data)
	{
	}

	public void DeleteNormalTableDataCache(string tableName, BBEGMKEHHFI.KLHEMBJCOPE data)
	{
	}

	public virtual void Commit()
	{
	}

	public virtual void Close()
	{
	}

	private string GenerateDataKey(string accountId, string key)
	{
		return null;
	}

	private Dictionary<string, BBEGMKEHHFI.KLHEMBJCOPE> GetNormalTableCache(string tableName, bool createIfMissing = false)
	{
		return null;
	}
}
