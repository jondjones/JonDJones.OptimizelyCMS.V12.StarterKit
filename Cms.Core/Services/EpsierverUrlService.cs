using Cms.Core.Interfaces;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Core.Services
{
    public class EpsierverUrlService : IEpsierverUrlService
    {
        private ISiteDefinitionRepository _siteDefinitionRepository;

        public EpsierverUrlService(ISiteDefinitionRepository siteDefinitionRepository)
        {
            _siteDefinitionRepository = siteDefinitionRepository;
        }

        public string GetPrimaryUrl()
        {
            var existingSites = _siteDefinitionRepository.List().FirstOrDefault();
            return existingSites.Hosts.FirstOrDefault(host => host.Type == HostDefinitionType.Primary).Url.OriginalString;
        }
    }
}