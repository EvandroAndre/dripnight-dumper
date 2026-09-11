namespace COW;

public interface INinthProgressState
{
	bool ProgressRedDot { get; }

	bool GetProgressIconInfo(out bool isNormal, out string iconUrl);
}
