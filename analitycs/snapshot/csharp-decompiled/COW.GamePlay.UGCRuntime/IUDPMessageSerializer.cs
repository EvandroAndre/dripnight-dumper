namespace COW.GamePlay.UGCRuntime;

public interface IUDPMessageSerializer
{
	byte[] Serialize(IMsgPool msgPool);

	byte[] Unserialize(byte[] data);

	Tuple2<byte[], bool> UnserializeChecked(byte[] data);
}
