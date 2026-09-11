namespace COW.Gameplay.UGC;

public class UGCVFSHeader
{
	public byte[] MagicNumber;

	public ushort Version;

	public ushort MiscInfo;

	public long FirstIndexChunkPosition;

	public long EmptySpacePosition;

	public byte[] Reserved;

	public static readonly byte[] VFS_MAGIC;

	public static readonly byte[] VFS_MAGIC_END;

	public const ushort CURRENT_VERSION = 1;

	public static uint HeaderSize => 0u;

	public void Serialize(UGCVFSBinarySerializer serializer)
	{
	}
}
