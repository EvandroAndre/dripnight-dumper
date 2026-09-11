namespace COW;

public enum EngineActionFlag
{
	ClearShaderLab = 1,
	CheckShaderKeywords = 2,
	InitShaderStripSettings = 4,
	CheckShaderKeywordsWithDataID = 8,
	UpdateShaderLabHashPropertyMap = 0x10,
	UnloadSubProgramSourceCode = 0x20,
	EnableGraphicsJobs = 0x40,
	EnableStopXRARVR = 0x80
}
