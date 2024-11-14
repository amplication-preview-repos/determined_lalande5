using Microsoft.AspNetCore.Mvc;
using Qualidade.APIs.Common;
using Qualidade.Infrastructure.Models;

namespace Qualidade.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class EstatisticasFindManyArgs : FindManyInput<Estatisticas, EstatisticasWhereInput> { }