using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chart.API.Models.ViewModels
{
    public class ChartViewModel
    {
        public string FeaturedCode { get; set; }
        public string ArtistName { get; set; }
        public List<ArtistViewModel> CreditedArtists { get; set; }
        public string Title { get; set; }
        public string Imprint { get; set; }
        public string Label { get; set; }
        public List<string> WriterNames { get; set; }
        public List<string> ShortWriterNames { get; set; }
        public List<WriterViewModel> CreditedWriters { get; set; }
        public List<string> ProducerNames { get; set; }
        public List<string> ShortProducerNames { get; set; }
        public List<ProducerViewModel> CreditedProducers { get; set; }
        public long ArtistID { get; set; }
        public long TitleID { get; set; }
        public int RankLw { get; set; }
        public int Rank2w { get; set; }
        public int PeakRank { get; set; }
        public DateTime PeakDate { get; set; }
        public int DebutRank { get; set; }
        public DateTime DebutDate { get; set; }
        public bool Bullet { get; set; }
        public bool BulletLw { get; set; }
        public bool Bullet2w { get; set; }
    }
}