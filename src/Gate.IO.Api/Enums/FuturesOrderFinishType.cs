﻿namespace Gate.IO.Api.Enums;

/// <summary>
/// How the order was finished.
/// </summary>
public enum FuturesOrderFinishType
{
    /// <summary>
    /// Enum Filled for value: filled
    /// </summary>
    [EnumMember(Value = "filled")]
    Filled,

    /// <summary>
    /// Enum Cancelled for value: cancelled
    /// </summary>
    [EnumMember(Value = "cancelled")]
    Cancelled,

    /// <summary>
    /// Enum Liquidated for value: liquidated
    /// </summary>
    [EnumMember(Value = "liquidated")]
    Liquidated,

    /// <summary>
    /// Enum Ioc for value: ioc
    /// </summary>
    [EnumMember(Value = "ioc")]
    IOC,

    /// <summary>
    /// Enum Autodeleveraged for value: auto_deleveraged
    /// </summary>
    [EnumMember(Value = "auto_deleveraged")]
    AutoDeleveraged,

    /// <summary>
    /// Enum Reduceonly for value: reduce_only
    /// </summary>
    [EnumMember(Value = "reduce_only")]
    ReduceOnly,

    /// <summary>
    /// Enum Positionclosed for value: position_closed
    /// </summary>
    [EnumMember(Value = "position_closed")]
    PositionClosed,

    /// <summary>
    /// Enum Reduceout for value: reduce_out
    /// </summary>
    [EnumMember(Value = "reduce_out")]
    ReduceOut
}
