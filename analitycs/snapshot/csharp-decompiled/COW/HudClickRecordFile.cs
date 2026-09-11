using System.Collections.Generic;

namespace COW;

public class HudClickRecordFile
{
	public int recordCount;

	public int screenWidth;

	public int screenHeight;

	public uint matchMode;

	public uint gameMode;

	public long time;

	public ulong accountId;

	public int hudPresetIndex;

	public List<GlobalClickRecorder.ClickRecord> clicks;

	public string signature;
}
