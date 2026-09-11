namespace COW;

public class ServerSettingsData
{
	public const string SBT_SERVER = "1";

	public const string LIVE_SERVER = "2";

	public const string IOS_SERVER = "3";

	public const string RCT_SERVER = "4";

	public const string PREVIEW_SERVER = "5";

	public const string BETA_SERVER = "6";

	public const string EXP_SERVER = "7";

	public const string ART_SERVER = "8";

	public const string DESIGN_SERVER = "9";

	public const string ACT_SERVER = "10";

	public int ID;

	public string VerAddr;

	public string CDNAddr;

	public string IconCDNAddr;

	public string ABHotUpdateCDNAddr;

	public string ServerAdd;

	public string BillboardServerAdd;

	public bool IsIOSReview;

	public string name;

	public bool Production;
}
