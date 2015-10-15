using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;

using Chart.API.Models.ViewModels;
using Chart.Business.DTO;

namespace Chart.API.Configuration
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

            Mapper.CreateMap<ChartCollectionDTO, ChartResponse>()
                .ForMember(dest => dest.ChartName, opts => opts.MapFrom(src => src.chart_name))
                .ForMember(dest => dest.FormatID, opts => opts.MapFrom(src => src.format_id))
                .ForMember(dest => dest.IssueDate, opts => opts.MapFrom(src => src.chart_date));

            Mapper.CreateMap<ChartDTO, ChartViewModel>()
                .ForMember(dest => dest.ArtistID, opts => opts.MapFrom(src => src.billboard_artist_id))
                .ForMember(dest => dest.ArtistName, opts => opts.MapFrom(src => src.artist_name))
                .ForMember(dest => dest.Bullet2w, opts => opts.MapFrom(src => src.bullet_2w))
                .ForMember(dest => dest.BulletLw, opts => opts.MapFrom(src => src.bullet_lw))
                .ForMember(dest => dest.CreditedArtists, opts => opts.MapFrom(src => src.credited_artists))
                .ForMember(dest => dest.CreditedProducers, opts => opts.MapFrom(src => src.credited_producers))
                .ForMember(dest => dest.CreditedWriters, opts => opts.MapFrom(src => src.credited_writers))
                .ForMember(dest => dest.DebutDate, opts => opts.MapFrom(src => src.debut_date))
                .ForMember(dest => dest.DebutRank, opts => opts.MapFrom(src => src.debut_rank))
                .ForMember(dest => dest.FeaturedCode, opts => opts.MapFrom(src => src.feature_code))
                .ForMember(dest => dest.Imprint, opts => opts.MapFrom(src => src.imprint))
                .ForMember(dest => dest.Label, opts => opts.MapFrom(src => src.label))
                .ForMember(dest => dest.PeakDate, opts => opts.MapFrom(src => src.peak_date))
                .ForMember(dest => dest.PeakRank, opts => opts.MapFrom(src => src.peak_rank))
                .ForMember(dest => dest.ProducerNames, opts => opts.MapFrom(src => src.producer_names))
                .ForMember(dest => dest.Rank2w, opts => opts.MapFrom(src => src.rank_2w))
                .ForMember(dest => dest.RankLw, opts => opts.MapFrom(src => src.rank_lw))
                .ForMember(dest => dest.ShortProducerNames, opts => opts.MapFrom(src => src.short_producer_names))
                .ForMember(dest => dest.ShortWriterNames, opts => opts.MapFrom(src => src.short_writer_names))
                .ForMember(dest => dest.TitleID, opts => opts.MapFrom(src => src.billboard_title_id))
                .ForMember(dest => dest.WriterNames, opts => opts.MapFrom(src => src.writer_names));

            Mapper.CreateMap<ArtistDTO, ArtistViewModel>()
                .ForMember(dest => dest.ArtistID, opts => opts.MapFrom(src => src.billboard_artist_id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.artist_name));

            Mapper.CreateMap<ProducerDTO, ProducerViewModel>()
                .ForMember(dest => dest.ProducerID, opts => opts.MapFrom(src => src.billboard_producer_id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.producer_name))
                .ForMember(dest => dest.ShortName, opts => opts.MapFrom(src => src.short_name));

            Mapper.CreateMap<WriterDTO, WriterViewModel>()
                .ForMember(dest => dest.WriterID, opts => opts.MapFrom(src => src.billboard_writer_id))
                .ForMember(dest => dest.Name, opts => opts.MapFrom(src => src.writer_name))
                .ForMember(dest => dest.ShortName, opts => opts.MapFrom(src => src.short_name));
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