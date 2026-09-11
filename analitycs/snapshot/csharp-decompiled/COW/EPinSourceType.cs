namespace COW;

public enum EPinSourceType : byte
{
	Default = 0,
	PinActivity = 1,
	PinMatch = 2,
	PinFFMax = 3,
	UpperLimit = 4,
	INVALID = byte.MaxValue
}
