namespace BitCoinTracker;

public class CoinDeskItem
{
    public BitCoinByDenomination bpi { get; set; } = new();
    public String chartName { get; set; } = String.Empty;
    public String disclaimer { get; set; } = String.Empty;
    public CoinDeskDateTime time { get; set; } = new();
}

public class BitCoinByDenomination
{
    public BitCoinPrice USD { get; set; } = new();
    public BitCoinPrice GBP { get; set; } = new();
    public BitCoinPrice EUR { get; set; } = new();
}
public class BitCoinPrice
{
    public String code { get; set; } = String.Empty;
    public String description { get; set; } = String.Empty;
    public String rate { get; set; } = String.Empty;
    public Double rate_float { get; set; } = 0.00;
    public String symbol { get; set; } = String.Empty;
}

public class CoinDeskDateTime
{
    public String updated { get; set; } = String.Empty;
    public String updatedISO { get; set; } = String.Empty;
    public String updateduk { get; set; } = String.Empty;
}
