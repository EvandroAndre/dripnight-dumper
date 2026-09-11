namespace proto;

public class CSPlayerSettingsReq
{
	public byte[] settings;

	public string version;

	public SettingsTransferStatus transfer_status;

	public int release_number;

	public bool force_update;
}
