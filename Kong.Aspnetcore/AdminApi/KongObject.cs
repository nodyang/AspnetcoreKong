﻿namespace Kong.Aspnetcore.AdminApi
{
    /// <summary>
    /// 表示带id的kong对象
    /// </summary>
    public class KongObject: IKongObject
    {
        /// <summary>
        /// 唯一标识符
        /// </summary>
        public string Id { get; set; }
    }
}
