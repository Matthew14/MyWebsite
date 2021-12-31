using MySite2.Runs.Dtos;
using MySite2.Runs.Models;

namespace MySite2.Runs.Profiles;

// ReSharper disable once UnusedMember.Global
public class RunsProfile : AutoMapper.Profile
{
    public RunsProfile()
    {
        CreateMap<Run, RunReadDto>();
        CreateMap<RunWriteDto, Run>();
    }
}