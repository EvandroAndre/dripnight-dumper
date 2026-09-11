using GCommon;

namespace COW;

public class AvatarSkillVoiceData : CSVBaseData, IGetId
{
	public uint SkillID;

	public float VolumeDecayEnemy;

	public float VolumeDecaySelf;

	public float VolumeDecayTeammate;

	public ResourceID AudioSource;

	public ResourceID FemaleVoice;

	public ResourceID MaleVoice;

	public ResourceID FemaleVoiceDefault;

	public ResourceID MaleVoiceDefault;

	public uint PlayStage;

	public bool IsInTeam2DSfx;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
