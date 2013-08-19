using Orchard.Core.Contents.Extensions;
using Orchard.Data;
using Orchard.Data.Migration;
using Orchard.ContentManagement.MetaData;
using Orchard.Indexing;
using Backbone.Sample.Models;

namespace Backbone.Sample
{
    public class Migrations : DataMigrationImpl
    {
        private readonly IRepository<ActorRecord> actorRepository;

        public Migrations(IRepository<ActorRecord> actorRepository)
        {
            this.actorRepository = actorRepository; 
        }

        public int Create()
        {            
            SchemaBuilder.CreateTable("ActorRecord", t =>
                t.Column<int>("Id", c => c.PrimaryKey().Identity())
                .Column<string>("ActorName")
                .Column<string>("CharacterName")
                .Column<string>("Picture"));

            return 1;
        }

        public int UpdateFrom1()
        {
            actorRepository.Create(new ActorRecord { ActorName = "Michael J. Fox", CharacterName = "Marty McFly", Picture = "michael-j-fox.jpg" });
            actorRepository.Create(new ActorRecord { ActorName = "Christopher Lloyd", CharacterName = "Dr. Emmett Brown", Picture = "christopher-lloyd.jpg" });
            actorRepository.Create(new ActorRecord { ActorName = "Lea Thompson", CharacterName = "Lorraine Baines", Picture = "lea-thompson.jpg" });
            actorRepository.Create(new ActorRecord { ActorName = "Crispin Glover", CharacterName = "George McFly", Picture = "crispin-glover.jpg" });
            actorRepository.Create(new ActorRecord { ActorName = "Thomas F. Wilson", CharacterName = "Biff Tannen", Picture = "thomas-f-wilson.jpg" });
            actorRepository.Create(new ActorRecord { ActorName = "Claudia Wells", CharacterName = "Jennifer Parker", Picture = "claudia-wells.jpg" });

            return 2;
        }
    }
}