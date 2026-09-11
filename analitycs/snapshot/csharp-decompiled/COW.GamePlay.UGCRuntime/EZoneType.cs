namespace COW.GamePlay.UGCRuntime;

public enum EZoneType : byte
{
	Stable = 0,
	PreShrink = 1,
	Shrink = 2,
	RandomPreShrink = 3,
	RandomShrink = 4,
	Count = 5,
	RandomPreMove = 6,
	RandomMove = 7,
	Invalid = byte.MaxValue
}
