using System;

namespace COW;

[Serializable]
internal class ServerConfig
{
	public string serverName;

	public string serverUrl;

	public bool garenaOverride;

	public bool garenaSandbox;

	public bool skipVersionCheck;
}
