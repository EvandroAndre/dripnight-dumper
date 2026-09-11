namespace COW.Gameplay.UGC;

public enum UGCVFSFileFlags : uint
{
	None = 0u,
	Compressed = 1u,
	Deleted = 2u,
	Encrypted = 4u,
	Reserved1 = 8u,
	Reserved2 = 0x10u,
	Reserved3 = 0x20u,
	Reserved4 = 0x40u,
	Reserved5 = 0x80u
}
