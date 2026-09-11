namespace COW;

public enum IL2cppSwitch
{
	MemoryThresholdBits = 0,
	MemoryThresholdMask = 4095,
	DivisorBits = 12,
	DivisorMask = 258048,
	ReservedMask = 536608768,
	ReservedBits = 18,
	OpenThreadStackShrink = 536870912,
	ForceOpen32Bit = 1073741824,
	Open = int.MinValue
}
