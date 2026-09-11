namespace GCommon;

public interface IClientMessageSerializer
{
	void Serialize(FastBinaryWriter writer);

	void UnSerialize(FastBinaryReader reader);
}
