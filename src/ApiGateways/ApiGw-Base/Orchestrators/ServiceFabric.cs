﻿using Microsoft.Extensions.Configuration;
using OcelotApiGw.Enums;
using OcelotApiGw.Services;

namespace OcelotApiGw.Orchestrators
{
    public class ServiceFabric : IOrchestratorStrategy
    {
        private readonly ISettingService _settingService;

        public ServiceFabric(ISettingService settingService)
        {
            _settingService = settingService;
        }

        public OrchestratorType OrchestratorType => OrchestratorType.SF;

        public IConfigurationBuilder ConfigureOrchestrator(IConfigurationBuilder builder)
        {
            var config = _settingService.GetConfiguration();

            return builder;
        }
    }
}
