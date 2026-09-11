using proto;

namespace COW;

internal class OtherSparkPetCreateParams
{
	public uint sparkPetStage;

	public uint collabSparkPetStage;

	public uint[] appearanceItemIdsSelf;

	public uint[] appearanceItemIdsCollab;

	public EFriend.SparkState stateSelf;

	public EFriend.SparkState stateCollab;

	public uint colorIDSelf;

	public uint colorIDCollab;

	public uint selfLoginStreakDays;

	public uint collabLoginStreakDays;
}
