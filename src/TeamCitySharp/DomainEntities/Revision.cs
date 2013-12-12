using System.Collections.Generic;

namespace TeamCitySharp.DomainEntities
{
    public class Revision
    {
        public string Version { get; set; }
    }

    public class RevisionWrapper
    {
        public List<Revision> Revision { get; set; }
    }
}