using message;

namespace COW.GamePlay.UGCRuntime;

public interface IUGCLocalDatabase
{
	BBEGMKEHHFI.KLHEMBJCOPE GetNormalTableData(GetUGCDatabaseNormalDataRequest req);

	BBEGMKEHHFI.KLHEMBJCOPE SetNormalTableData(SetUGCDatabaseNormalDataRequest req);

	BBEGMKEHHFI.KLHEMBJCOPE DeleteNormalTableData(DeleteUGCDatabaseNormalDataRequest req);

	void Commit();

	void Close();
}
