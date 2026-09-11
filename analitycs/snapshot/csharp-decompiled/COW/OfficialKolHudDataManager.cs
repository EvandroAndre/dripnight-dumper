using System.Collections.Generic;
using GCommon;
using LitJson;

namespace COW;

internal class OfficialKolHudDataManager : SingletonModule<OfficialKolHudDataManager>
{
	public class OfficialKolHudData
	{
		public string OfficialName;

		public ulong OfficialAccountId;

		public uint OfficialHudIndex;

		public string OfficialHudTitle;

		public string OfficialHudDesc;

		public List<uint> OfficialHudTagList;

		public string OfficialHudSetting;
	}

	public string OfficialName;

	public ulong OfficialAccountId;

	public uint OfficialHudIndex;

	public string OfficialHudTitle;

	public string OfficialHudDesc;

	public List<uint> OfficialHudTagList;

	public List<uint> FilterTagList;

	public string OfficialHudSetting;

	public bool LoadKolHudData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	private void LoadOfficialKolHudData()
	{
	}

	private void LoadDataFromJsonData(JsonData JObjRoot)
	{
	}
}
