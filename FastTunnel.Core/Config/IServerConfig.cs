﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FastTunnel.Core.Config
{
    public interface IServerConfig
    {
        string BindAddr { get; set; }

        int BindPort { get; set; }

        #region Web相关配置

        int WebProxyPort { get; set; }

        string WebDomain { get; set; }

        /// <summary>
        /// 可选项
        /// 当前服务器是否开启了80端口转发至ProxyPort_HTTP的配置
        /// </summary>
        bool WebHasNginxProxy { get; set; }

        /// <summary>
        /// 可选项
        /// 访问web白名单
        /// </summary>
        string[] WebAllowAccessIps { get; set; }

        #endregion

        bool SSHEnabled { get; set; }

        public string Token { get; set; }
    }
}
