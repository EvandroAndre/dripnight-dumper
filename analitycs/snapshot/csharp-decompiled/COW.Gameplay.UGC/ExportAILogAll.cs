using System.Collections.Generic;

namespace COW.Gameplay.UGC;

public class ExportAILogAll
{
	public List<ExportFrameLogList> AllCmds;

	public bool IsFe;

	public ulong TimeStamp;

	public uint TemplateID;

	public uint AreaID;

	public uint MapID;

	public string WorkshopCode;

	public void Clear()
	{
	}
}
