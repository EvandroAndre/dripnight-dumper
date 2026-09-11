using System;

namespace COW;

[Serializable]
public class VodkaConfig
{
	public string httpServer;

	public int serverId;

	public string region;

	public VodkaLogLevel logLevel;

	public bool debug;
}
