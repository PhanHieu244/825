namespace GleyMobileAds
{
    using System.Collections.Generic;
    using UnityEngine.Events;

    /// <summary>
    /// interface implemented by all supported advertisers
    /// </summary>
    public interface ICustomAds
    {

    }
}

public enum BannerPosition
{
    TOP,
    BOTTOM
}

public enum BannerType
{
    Banner,
    SmartBanner,
    /// <summary>
    /// Only works for Admob
    /// </summary>
    Adaptive
}
