namespace tcp;

public class EModeStats
{
	public enum Proto
	{
		Proto_NONE,
		Proto_SCORE_UPDATE_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}

	public enum ScoreKey
	{
		ScoreKey_NONE,
		ScoreKey_KILLS,
		ScoreKey_MATCHES,
		ScoreKey_WINS
	}
}
