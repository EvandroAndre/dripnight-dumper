using System.IO;

namespace COW.Gameplay.UGC.BlockEdit;

public interface ISerializableValue
{
	byte Type { get; }

	void Serialize(BinaryWriter writer);

	void Deserialize(BinaryReader reader);
}
