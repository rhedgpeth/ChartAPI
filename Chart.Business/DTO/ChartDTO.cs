using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.Business.DTO
{
    public class ChartDTO
    {
        public string feature_code { get; set; }
        public string artist_name { get; set; }
        public List<ArtistDTO> credited_artists { get; set; }
        public string title { get; set; }
        public string imprint { get; set; }
        public string label { get; set; }

        public string writer_names { get; set; }
        //public List<string> writer_names { get; set; }

        public string short_writer_names { get; set; }
        //public List<string> short_writer_names { get; set; }

        public List<WriterDTO> credited_writers { get; set; }

        public string producer_names { get; set; }
        //public List<string> producer_names { get; set; }

        public string short_producer_names { get; set; }
        //public List<string> short_producer_names { get; set; }

        public List<ProducerDTO> credited_producers { get; set; }
        public long billboard_artist_id { get; set; }
        public long billboard_title_id { get; set; }
        public int rank_lw { get; set; }
        public int rank_2w { get; set; }
        public int peak_rank { get; set; }
        public DateTime peak_date { get; set; }
        public int debut_rank { get; set; }
        public DateTime debut_date { get; set; }
        public bool bullet { get; set; }
        public bool bullet_lw { get; set; }
        public bool bullet_2w { get; set; }
    }

    /*
      "rank": 1,
			"feature_code": " ",
			"artist_name": "Mark Ronson Featuring Bruno Mars",
			"credited_artists": [ 
				{
					"billboard_artist_id": 85391,
					"artist_name": "Mark Ronson",
					"credit": 0.7
				},
				{
					"billboard_artist_id": 107277,
					"artist_name": "Bruno Mars",
					"credit": 0.3
				}],
			"title": "Uptown Funk!",
			"imprint": "RCA",
			"label": "",
			"writer_names": "Peter \"Bruno Mars\" Gene Hernandez, Philip Lawrence II, Mark Ronson, Jeffrey Bhasker, Devon Gallaspy, Nicholaus \"Trinidad James\" Williams",
			"short_writer_names": "Bruno Mars, P.Lawrence II, M.Ronson, J.Bhasker, D.Gallaspy, N.Williams",
			"credited_writers": [ 
				{
					"billboard_writer_id": 18838,
					"writer_name": "Mark Ronson",
					"short_name": "M.Ronson"
				},
				{
					"billboard_writer_id": 20415,
					"writer_name": "Jeffrey Bhasker",
					"short_name": "J.Bhasker"
				},
				{
					"billboard_writer_id": 22269,
					"writer_name": "Philip Lawrence II",
					"short_name": "P.Lawrence II"
				},
				{
					"billboard_writer_id": 22562,
					"writer_name": "Peter \"Bruno Mars\" Gene Hernandez",
					"short_name": "Bruno Mars"
				},
				{
					"billboard_writer_id": 27272,
					"writer_name": "Nicholaus \"Trinidad James\" Williams",
					"short_name": "N.Williams"
				},
				{
					"billboard_writer_id": 29719,
					"writer_name": "Devon Gallaspy",
					"short_name": "D.Gallaspy"
				}],
			"producer_names": "Mark Ronson, Jeffrey Bhasker, Peter \"Bruno Mars\" Hernandez",
			"short_producer_names": "M.Ronson, J.Bhasker, Bruno Mars",
			"credited_producers": [ 
				{
					"billboard_producer_id": 13969,
					"producer_name": "Mark Ronson",
					"short_name": "M.Ronson"
				},
				{
					"billboard_producer_id": 14834,
					"producer_name": "Jeffrey Bhasker",
					"short_name": "J.Bhasker"
				},
				{
					"billboard_producer_id": 15973,
					"producer_name": "Peter \"Bruno Mars\" Hernandez",
					"short_name": "Bruno Mars"
				}],
			"billboard_artist_id": 133673,
			"billboard_title_id": 868081,
			"rank_lw": 1,
			"rank_2w": 1,
			"peak_rank": 1,
			"peak_date": "01/17/2015",
			"debut_rank": 65,
			"debut_date": "11/29/2014",
			"bullet": false,
			"bullet_lw": false,
			"bullet_2w": true
    */
}
