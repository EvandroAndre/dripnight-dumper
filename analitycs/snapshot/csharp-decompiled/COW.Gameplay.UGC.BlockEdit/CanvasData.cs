namespace COW.Gameplay.UGC.BlockEdit;

public class CanvasData
{
	public float positionX;

	public float positionY;

	public float scale;

	public bool Deserialize<T>(IBlockDeserializer<T> deserializer, T serializedData) where T : class
	{
		return false;
	}

	public bool Serialize<T>(IBlockSerializer<T> serializer, T serializedData) where T : class
	{
		return false;
	}

	public CanvasData Clone()
	{
		return null;
	}
}
