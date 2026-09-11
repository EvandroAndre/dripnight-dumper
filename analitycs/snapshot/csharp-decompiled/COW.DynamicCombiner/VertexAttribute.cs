namespace COW.DynamicCombiner;

internal enum VertexAttribute
{
	None = 0,
	Normal = 2,
	Tangent = 4,
	Color = 8,
	TexCoord0 = 16,
	TexCoord1 = 32,
	TexCoord2 = 64,
	TexCoord3 = 128,
	TexCoord4 = 256,
	TexCoord5 = 512,
	TexCoord6 = 1024,
	TexCoord7 = 2048,
	All = int.MinValue
}
