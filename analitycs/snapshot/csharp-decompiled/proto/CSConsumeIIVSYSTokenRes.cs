using System.Collections.Generic;

namespace proto;

public class CSConsumeIIVSYSTokenRes
{
	public uint cur_progress;

	public ExchangeChangeData rewards;

	public List<IIVRateControlDesc> rate_results;
}
