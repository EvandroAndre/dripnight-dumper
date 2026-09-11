using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCLocalDatabaseProxy : IUGCLocalDatabase
{
	private readonly UGCLocalDatabase m_LocalDB;

	private readonly UGCLocalDatabaseCache m_CacheDB;

	public UGCLocalDatabaseProxy(UGCRuntime ugcRuntime, string workshopCode)
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

	public void Close()
	{
	}

	public void Commit()
	{
	}
}
