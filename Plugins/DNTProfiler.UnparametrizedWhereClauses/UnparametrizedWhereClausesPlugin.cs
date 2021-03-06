﻿using System.Windows.Controls;
using DNTProfiler.PluginsBase;

namespace DNTProfiler.UnparametrizedWhereClauses
{
    public class UnparametrizedWhereClausesPlugin : ProfilerPluginBase
    {
        public UnparametrizedWhereClausesPlugin()
        {
            PluginMetadata = new PluginMetadata
            {
                PluginName = "Unparameterized Where Clauses",
                PluginDescription = "Unparameterized queries(ad-hoc queries) will cause more resource consumption (higher CPU and Memory usage of the the database server)."
            };

            PluginAuthor = new PluginAuthor
            {
                Name = "VahidN",
                Email = "",
                WebSiteUrl = "http://www.dotnettips.info"
            };

            Category = PluginCategory.Alerts;
        }

        public override UserControl GetPluginUI()
        {
            return new Main(this);
        }
    }
}