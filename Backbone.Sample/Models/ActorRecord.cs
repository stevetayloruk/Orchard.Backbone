using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backbone.Sample.Models
{
    public class ActorRecord
    {
       
        public virtual int Id { get; set; }
        public virtual string ActorName { get; set; }
        public virtual string CharacterName { get; set; }
        public virtual string Picture { get; set; }

        //public virtual IList<EpisodeActorRecord> ActorEpisodes { get; set; }
    }
}