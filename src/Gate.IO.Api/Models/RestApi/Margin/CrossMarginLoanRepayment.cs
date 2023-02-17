namespace Gate.IO.Api.Models.RestApi.Margin;

public class CrossMarginLoanRepayment
{
    [JsonProperty("currency")]
    public string Currency { get; set; }

    [JsonProperty("amount")]
    public decimal Amount { get; set; }
}