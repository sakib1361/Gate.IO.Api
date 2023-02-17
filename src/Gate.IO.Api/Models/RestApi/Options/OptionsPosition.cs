namespace Gate.IO.Api.Models.RestApi.Options;

public class OptionsPosition
{
    /// <summary>
    /// User ID
    /// </summary>
    [JsonProperty("user")]
    public int User { get; set; }

    /// <summary>
    /// Options contract name
    /// </summary>
    [JsonProperty("contract")]
    public string Contract { get; set; }

    /// <summary>
    /// Position size (contract size)
    /// </summary>
    [JsonProperty("size")]
    public long Size { get; set; }

    /// <summary>
    /// Entry size (quote currency)
    /// </summary>
    [JsonProperty("entry_price")]
    public decimal EntryPrice { get; set; }

    /// <summary>
    /// Current mark price (quote currency)
    /// </summary>
    [JsonProperty("mark_price")]
    public decimal MarkPrice { get; set; }

    /// <summary>
    /// Realized PNL
    /// </summary>
    [JsonProperty("realised_pnl")]
    public decimal RealisedPnl { get; set; }

    /// <summary>
    /// Unrealized PNL
    /// </summary>
    [JsonProperty("unrealised_pnl")]
    public decimal UnrealisedPnl { get; set; }

    /// <summary>
    /// Current open orders
    /// </summary>
    [JsonProperty("pending_orders")]
    public int PendingOrders { get; set; }

    /// <summary>
    /// Gets or Sets CloseOrder
    /// </summary>
    [JsonProperty("close_order")]
    public OptionsPositionCloseOrder CloseOrder { get; set; }
}