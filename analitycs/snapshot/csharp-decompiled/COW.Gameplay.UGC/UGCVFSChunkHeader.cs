namespace COW.Gameplay.UGC;

public class UGCVFSChunkHeader
{
	public byte[] MagicNumber;

	public uint DataChunkSize;

	public long IndexChunkPosition;

	public uint IndexChunkSize;

	public long NextChunkPosition;

	public static readonly byte[] IDX_MAGIC;

	public long ChunkHeaderPosition;

	public static uint HeaderSize => 0u;

	public long DataChunkPosition => 0L;

	public void Serialize(UGCVFSBinarySerializer serializer)
	{
	}
}
