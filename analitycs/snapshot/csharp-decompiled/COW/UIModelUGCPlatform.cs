using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

public class UIModelUGCPlatform : UIBaseModel
{
	public override uint GetModelType()
	{
		return 0u;
	}

	public bool LoadUGCGamePlatformData(string resName, out FDBINMGLMNA platformData)
	{
		platformData = null;
		return false;
	}

	public void UploadWorkshopPlatform(CSGetUploadWorkshopURLReq req)
	{
	}

	public void ExportProjectMetaData(KKMFBJGIEBD metaData)
	{
	}

	private List<WorkshopDataStorage> ConvertToWorkshopDataStorages(List<FDBINMGLMNA.GIEKGJOOGEC> dataStorages)
	{
		return null;
	}

	private List<WorkshopLeaderboard> ConvertToWorkshopLeaderboards(List<FDBINMGLMNA.GIPDPENGAIJ> leaderboards)
	{
		return null;
	}
}
