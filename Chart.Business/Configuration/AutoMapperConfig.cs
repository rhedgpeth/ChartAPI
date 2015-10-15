using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using Chart.Business.DTO;
using Chart.Data.Entities;

namespace Chart.Business.Configuration
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.AddProfile(new CoreProfile());
        }
    }

    public class CoreProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<string, List<string>>().ConvertUsing<CommaDelimitedStringConverter>();

            Mapper.CreateMap<ChartCollection, ChartCollectionDTO>()
                .ForMember(dest => dest.chart_name, opts => opts.MapFrom(src => src.formatName))
                .ForMember(dest => dest.format_id, opts => opts.MapFrom(src => src.formatid))
                .ForMember(dest => dest.chart_date, opts => opts.MapFrom(src => src.issue_date))
                .ForMember(dest => dest.total, opts => opts.MapFrom(src => src.row_count));

            Mapper.CreateMap<Chart.Data.Entities.Chart, ChartDTO>()
                .ForMember(dest => dest.billboard_artist_id, opts => opts.MapFrom(src => src.artistid))
                .ForMember(dest => dest.artist_name, opts => opts.MapFrom(src => src.artistname))
                .ForMember(dest => dest.bullet, opts => opts.MapFrom(src => src.has_bullet_desc))
                .ForMember(dest => dest.bullet_2w, opts => opts.MapFrom(src => src.has_2w_bullet_desc))
                .ForMember(dest => dest.bullet_lw, opts => opts.MapFrom(src => src.has_lw_bullet_desc))
                .ForMember(dest => dest.debut_date, opts => opts.MapFrom(src => src.debutdate))
                .ForMember(dest => dest.debut_rank, opts => opts.MapFrom(src => src.debutpos))
                .ForMember(dest => dest.imprint, opts => opts.MapFrom(src => src.displaydistlabel)) 
                .ForMember(dest => dest.label, opts => opts.MapFrom(src => src.displaylabel))
                .ForMember(dest => dest.peak_date, opts => opts.MapFrom(src => src.peakdate))
                .ForMember(dest => dest.peak_rank, opts => opts.MapFrom(src => src.peakpos))
                .ForMember(dest => dest.producer_names, opts => opts.MapFrom(src => src.producer_desc))
                .ForMember(dest => dest.short_producer_names, opts => opts.MapFrom(src => src.producer_short_desc))
                .ForMember(dest => dest.short_writer_names, opts => opts.MapFrom(src => src.writer_short_desc))
                .ForMember(dest => dest.billboard_title_id, opts => opts.MapFrom(src => src.titleid))
                .ForMember(dest => dest.writer_names, opts => opts.MapFrom(src => src.writer_desc));

            Mapper.CreateMap<Artist, ArtistDTO>()
                .ForMember(dest => dest.billboard_artist_id, opts => opts.MapFrom(src => src.artistid));

            Mapper.CreateMap<Producer, ProducerDTO>()
                .ForMember(dest => dest.billboard_producer_id, opts => opts.MapFrom(src => src.producerid))
                .ForMember(dest => dest.producer_name, opts => opts.MapFrom(src => src.name))
                .ForMember(dest => dest.short_name, opts => opts.MapFrom(src => src.shortname));

            Mapper.CreateMap<Writer, WriterDTO>()
                .ForMember(dest => dest.billboard_writer_id, opts => opts.MapFrom(src => src.writerid))
                .ForMember(dest => dest.writer_name, opts => opts.MapFrom(src => src.writername))
                .ForMember(dest => dest.short_name, opts => opts.MapFrom(src => src.shortname));
        }
    }

    public class CommaDelimitedStringConverter : TypeConverter<string, List<string>>
    {
        protected override List<string> ConvertCore(string source)
        {
            List<string> result = null;

            if (source.Length > 0)
            {
                result = source.Split(',').ToList();
                result = result.Select(s => s.Trim()).ToList();
            }

            return result;
        }
    }
}
