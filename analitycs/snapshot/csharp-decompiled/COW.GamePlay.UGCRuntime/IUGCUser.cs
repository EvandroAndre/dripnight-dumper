namespace COW.GamePlay.UGCRuntime;

public interface IUGCUser
{
	bool SendData(uint cmd, IUDPMessageSerializer msg, byte sendOption);

	bool SendBytes(uint cmd, byte[] data, byte sendOption);

	uint GetProtoPlayerID();

	ulong GetUserID();
}
